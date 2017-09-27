using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace SJTradeRobo
{
    public partial class FrmKiwoomOcx : Form
    {
        private EventLog m_log;
        public int m_LoginState = TradeVars.TV_STS_NOTCONNECTED;
        private FrmMain m_Parent= null;
        public FrmKiwoomOcx()
        {
            InitializeComponent();
        }

        public FrmKiwoomOcx(FrmMain frm)
        {
            InitializeComponent();
            m_Parent = frm;
            m_log = new EventLog();
            m_log.Source = TradeVars.APP_NAME;
        }

        private void FrmKiwoomOcx_Load(object sender, EventArgs e)
        {
            
        }

        private void axKHOpenAPI1_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if(Error.IsError(e.nErrCode))
            {                
                m_LoginState = TradeVars.TV_STS_CONNECTED;                
            }
            else
            {
                m_LoginState = TradeVars.TV_STS_NOTCONNECTED;
            }
            m_Parent.UpdateState(TradeVars.MSG_STATE_UPDATE, null);
            m_log.WriteEntry("[로그인 처리결과] " + Error.GetErrorMessage());
        }

        private void axKHOpenAPI1_OnReceiveChejanData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEvent e)
        {

        }

        private void axKHOpenAPI1_OnReceiveConditionVer(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {

        }

        private void axKHOpenAPI1_OnReceiveInvestRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveInvestRealDataEvent e)
        {

        }

        private void axKHOpenAPI1_OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {

        }

        private void axKHOpenAPI1_OnReceiveTrCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {

        }

        private void axKHOpenAPI1_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {

        }

        private void axKHOpenAPI1_OnReceiveMsg(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEvent e)
        {

        }

        /// <summary>
        /// 외부 인터페이스 선언 
        /// </summary>
        public void DoLogin(bool bVal)
        {
            if (m_LoginState == TradeVars.TV_STS_NOTCONNECTED && bVal == true)
            {
                m_log.WriteEntry("Start Kiwoom Server Login...");
                axKHOpenAPI1.CommConnect();

            }
            else if(m_LoginState == TradeVars.TV_STS_CONNECTED && bVal == false)
            {
                //logout
                axKHOpenAPI1.CommTerminate();
                m_LoginState = TradeVars.TV_STS_NOTCONNECTED;
                m_Parent.UpdateState(TradeVars.MSG_STATE_UPDATE, null);
            }
            else
            {
                m_log.WriteEntry("Current Status " + m_LoginState + " vVal is " + bVal);
            }
        }
    }
}
