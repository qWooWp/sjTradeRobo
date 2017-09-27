using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//EventLog
using System.Diagnostics;


namespace SJTradeRobo
{
    public partial class FrmMain : Form
    {
        private EventLog m_log;
        private FrmKiwoomOcx m_kiwoom;
        public FrmMain()
        {
            InitializeComponent();

            if (!EventLog.SourceExists(TradeVars.APP_NAME))
                EventLog.CreateEventSource(TradeVars.APP_NAME, "Application");
                
            m_log = new EventLog();
            m_log.Source = TradeVars.APP_NAME;
            m_log.WriteEntry("Start Application.");

            m_kiwoom = new FrmKiwoomOcx(this);           
            
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start(@"cmd.exe", @"/k D:\Project\SJTradeRobo\SJTradeRobo\bin\Debug\SJTradeRobo.exe");
        }

        public void UpdateState(int msg, string data)
        {
            switch(msg)
            {
                case TradeVars.MSG_STATE_UPDATE:
                    if(m_kiwoom.m_LoginState == TradeVars.TV_STS_NOTCONNECTED)
                    {
                        MenuItem_로그인.Text = "로그인";
                    }
                    else
                    {
                        //연결 상태 
                        MenuItem_로그인.Text = "로그아웃";
                    }
                    break;
                default:
                    m_log.WriteEntry("Unknown message : " + msg.ToString() );
                    break;

            }
        }

        /// <summary>
        /// 외부 로그 감시 프로그램 실행 기능
        /// </summary>
        System.Diagnostics.Process log_program = null; 
        private void 로그감시ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(sender == menuItem_Log)
            {
                if (menuItem_Log.Checked)
                {
                    menuItem_Log.Checked = false;
                    if (log_program != null)
                        log_program.Kill();
                }
                else
                {
                    menuItem_Log.Checked = true;
                    //화면 크기를 전달. 
                    string arg1 = Screen.PrimaryScreen.Bounds.Width.ToString();
                    string arg2 = Screen.PrimaryScreen.Bounds.Height.ToString();
                    string args = arg1 + " " + arg2;
                    log_program = System.Diagnostics.Process.Start(@"D:\Project\JSRobo\SJRoboLog.exe", args);
                }

            }
        }
        
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)

        {
            
        }

        //로그인 요청
        private void MenuItem_로그인_Click(object sender, EventArgs e)
        {
            if (m_kiwoom.m_LoginState == TradeVars.TV_STS_NOTCONNECTED)
            {
                m_kiwoom.DoLogin(true);
            }
            else
            {
                m_kiwoom.DoLogin(false);
            }
        }

        private void MenuItem_데이터감시시작_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem_데이터감시종료_Click(object sender, EventArgs e)
        {

        }

        private void MenuItem_데이터감시설정_Click(object sender, EventArgs e)
        {

        }
    }
}
