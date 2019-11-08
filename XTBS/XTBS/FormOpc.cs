using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OPCAutomation;
using System.Net;

namespace XTBS
{
    public partial class FormOpc : Form
    {
        public FormOpc()
        {
            InitializeComponent();
        }
        #region 变量

        //OPCServer的IP
        private String strHostIP;
        //OPCServer的主机名
        private String strHostName;
        //是否和OPCServer建立连接
        private Boolean opc_connected;
        //建立的OPCServer对象
        private OPCServer myServer;
        //OPCServer节点浏览器
        private OPCBrowser myOPCBrowser;
        //分组集合
        private OPCGroups myGroups;
        //分组实例
        private OPCGroup myGroup;
        //分组的TAG节点
        private OPCItems myItems;
        //服务端句柄
        int itmHandleServer = 0;
        //要写入的叶子节点
        private OPCItem[] myItemArray;

        #endregion
        /// <summary>
        /// 每当项数据有变化时执行的事件
        /// </summary>
        /// <param name="TransactionID">处理ID</param>
        /// <param name="NumItems">项个数</param>
        /// <param name="ClientHandles">项客户端句柄</param>
        /// <param name="ItemValues">TAG值</param>
        /// <param name="Qualities">品质</param>
        /// <param name="TimeStamps">时间戳</param>
        void myGroup_DataChange(int TransactionID, int NumItems, ref Array ClientHandles, ref Array ItemValues, ref Array Qualities, ref Array TimeStamps)
        {
            for (int i = 1; i <= NumItems; i++)
            {
                txtValue.Text = ItemValues.GetValue(i).ToString();
            }
            //为方便测试，显示到状态栏输出
            lblState.Text = "TransactionID:" + TransactionID.ToString() + "--" + "NumItems:" + NumItems.ToString();
        }

        /// <summary>
        /// 写入TAG值时执行的事件
        /// </summary>
        /// <param name="TransactionID">处理ID</param>
        /// <param name="NumItems">项个数</param>
        /// <param name="ClientHandles">项客户端句柄</param>
        /// <param name="Errors">服务器返回的错误信息</param>
        void myGroup_AsyncWriteComplete(int TransactionID, int NumItems, ref Array ClientHandles, ref Array Errors)
        {
            //为方便测试，显示到状态栏输出
            for (int i = 1; i <= NumItems; i++)
            {
                lblState.Text = "TransactionID:" + TransactionID.ToString() + "--" + "ClientHandle:" + ClientHandles.GetValue(i).ToString() + "--" + "ErrorValue: " + Errors.GetValue(i).ToString();
            }
        }


        #region 触发事件


        private void FormOpc_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConIP_Click(object sender, EventArgs e)
        {
            //根据输入获取OPC服务器IP地址
            strHostIP = txtIP.Text;
            //通过IP来获取OPC服务器主机名
            IPHostEntry ipHostEntry = Dns.GetHostEntry(strHostIP);
            strHostName = ipHostEntry.HostName.ToString();
            try
            {
                //实例化OPC服务
                myServer = new OPCServer();
                //获取OPCServer列表
                object serverList = myServer.GetOPCServers(strHostName);
                //将OPCServer展示到ComboBox
                foreach (string turn in (Array)serverList)
                {
                    cmbServer.Items.Add(turn);
                }
                cmbServer.SelectedIndex = 0;
                //开启OPC连接按钮
                btnOPC.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("枚举OPC服务出错：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnOPC_Click(object sender, EventArgs e)
        {
            try
            {
                //根据选择的OPCServer进行连接
                myServer.Connect(cmbServer.Text, strHostIP);
                //根据连接成功与否输出状态信息
                if (myServer.ServerState == (int)OPCServerState.OPCRunning)
                {
                    lblState.Text = "已连接到:" + myServer.ServerName;
                    //显示服务器信息
                    lblState.Text += "----开始时间:" + myServer.StartTime.ToString();
                    lblState.Text += "----版本:" + myServer.MajorVersion.ToString() + "." + myServer.MinorVersion.ToString() + "." + myServer.BuildNumber.ToString();
                }
                else
                {
                    lblState.Text = "状态：" + myServer.ServerState.ToString();
                }
                //已连接标记
                opc_connected = true;
                //开启获取标签按钮
                btnGetGrps.Enabled = true;
                MessageBox.Show("链接OPC成功");
            }
            catch (Exception err)
            {
                MessageBox.Show("初始化出错：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnGetGrps_Click(object sender, EventArgs e)
        {
            //实例化Tag浏览器
            myOPCBrowser = myServer.CreateBrowser();
            //展开分组
            myOPCBrowser.ShowBranches();
            //展开标签
            myOPCBrowser.ShowLeafs(true);
            //将所有分支和叶子节点显示到ListBox
            lstItems.Items.Clear();
            foreach (object turn in myOPCBrowser)
            {
                lstItems.Items.Add(turn.ToString());
            }
            //开启定位标签按钮
            btnSetItem.Enabled = true;
        }

        private void btnSetItem_Click(object sender, EventArgs e)
        {
            try
            {
                /**
                 * 需要注意，不同的OPC服务器的标签格式也是不同的
                 * 测试时，使用的是ICONICS Simulator OPC Server，标签格式如：Textual.Memory
                 * 生产环境时，使用的是SimaticNet_V13Sp1，标签格式如：S7:[S7_Connection_1]MReal120
                 * **/
                //根据ListBox选中的标签，处理得到分组名称
                string groupName = lstItems.Text;
                //实例化组
                myGroups = myServer.OPCGroups;
                myGroup = myGroups.Add(groupName);
                //设置缺省的组属性
                myServer.OPCGroups.DefaultGroupIsActive = true;
                myServer.OPCGroups.DefaultGroupDeadband = 0;
                myGroup.UpdateRate = 250;
                myGroup.IsActive = true;
                myGroup.IsSubscribed = true;
                //定位需要发送数据的目标项
                myItems = myGroup.OPCItems;
                //实例化组内标签
                myItemArray = new OPCItem[1];
                //填充项目组
                myItemArray[0] = myItems.AddItem(lstItems.Text, 1);
                //获取服务端句柄
                itmHandleServer = myItemArray[0].ServerHandle;
                //监听组内数据变化
                myGroup.DataChange += new DIOPCGroupEvent_DataChangeEventHandler(myGroup_DataChange);
                myGroup.AsyncWriteComplete += new DIOPCGroupEvent_AsyncWriteCompleteEventHandler(myGroup_AsyncWriteComplete);
                //开启发送参数按钮
                btnWrite.Enabled = true;
            }
            catch (Exception err)
            {
                MessageBox.Show("创建组出现错误：" + err.Message, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //获取之前定位的标签
            OPCItem bItem = myItems.GetOPCItem(itmHandleServer);
            //根据用户界面输入生成数据对象
            int[] temp = new int[2] { 0, bItem.ServerHandle };
            Array serverHandles = (Array)temp;
            object[] valueTemp = new object[2] { "", txtMyValue.Text };
            Array values = (Array)valueTemp;
            Array Errors;
            int cancelID;
            //异步写入到OPC服务器
            myGroup.AsyncWrite(1, ref serverHandles, ref values, out Errors, 2009, out cancelID);
            //回收资源
            GC.Collect();
        }

        private void FormOpc_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!opc_connected)
            {
                return;
            }
            if (myGroup != null)
            {
                myGroup.DataChange -= new DIOPCGroupEvent_DataChangeEventHandler(myGroup_DataChange);
            }
            if (myServer != null)
            {
                myServer.Disconnect();
            }
            opc_connected = false;
        }
    }
    #endregion
}