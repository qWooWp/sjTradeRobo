namespace SJTradeRobo
{
    partial class FrmKiwoomOcx
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKiwoomOcx));
            this.axKHOpenAPI1 = new AxKHOpenAPILib.AxKHOpenAPI();
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).BeginInit();
            this.SuspendLayout();
            // 
            // axKHOpenAPI1
            // 
            this.axKHOpenAPI1.Enabled = true;
            this.axKHOpenAPI1.Location = new System.Drawing.Point(31, 16);
            this.axKHOpenAPI1.Name = "axKHOpenAPI1";
            this.axKHOpenAPI1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI1.OcxState")));
            this.axKHOpenAPI1.Size = new System.Drawing.Size(100, 50);
            this.axKHOpenAPI1.TabIndex = 0;
            this.axKHOpenAPI1.OnReceiveTrData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEventHandler(this.axKHOpenAPI1_OnReceiveTrData);
            this.axKHOpenAPI1.OnReceiveRealData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEventHandler(this.axKHOpenAPI1_OnReceiveRealData);
            this.axKHOpenAPI1.OnReceiveMsg += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEventHandler(this.axKHOpenAPI1_OnReceiveMsg);
            this.axKHOpenAPI1.OnReceiveChejanData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveChejanDataEventHandler(this.axKHOpenAPI1_OnReceiveChejanData);
            this.axKHOpenAPI1.OnEventConnect += new AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEventHandler(this.axKHOpenAPI1_OnEventConnect);
            this.axKHOpenAPI1.OnReceiveInvestRealData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveInvestRealDataEventHandler(this.axKHOpenAPI1_OnReceiveInvestRealData);
            this.axKHOpenAPI1.OnReceiveTrCondition += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEventHandler(this.axKHOpenAPI1_OnReceiveTrCondition);
            this.axKHOpenAPI1.OnReceiveConditionVer += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEventHandler(this.axKHOpenAPI1_OnReceiveConditionVer);
            // 
            // FrmKiwoomOcx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 119);
            this.Controls.Add(this.axKHOpenAPI1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmKiwoomOcx";
            this.Text = "FrmKiwoomOcx";
            this.Load += new System.EventHandler(this.FrmKiwoomOcx_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI1;
    }
}