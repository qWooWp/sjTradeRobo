namespace SJTradeRobo
{
    partial class FrmMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_로그인 = new System.Windows.Forms.ToolStripMenuItem();
            this.관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_Log = new System.Windows.Forms.ToolStripMenuItem();
            this.계좌관리ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_데이터관리 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_데이터감시설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_데이터감시시작 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_데이터감시종료 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_로그인,
            this.관리ToolStripMenuItem,
            this.계좌관리ToolStripMenuItem,
            this.MenuItem_데이터관리});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1229, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // MenuItem_로그인
            // 
            this.MenuItem_로그인.Name = "MenuItem_로그인";
            this.MenuItem_로그인.Size = new System.Drawing.Size(88, 34);
            this.MenuItem_로그인.Text = "로그인";
            this.MenuItem_로그인.Click += new System.EventHandler(this.MenuItem_로그인_Click);
            // 
            // 관리ToolStripMenuItem
            // 
            this.관리ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_Log});
            this.관리ToolStripMenuItem.Name = "관리ToolStripMenuItem";
            this.관리ToolStripMenuItem.Size = new System.Drawing.Size(67, 34);
            this.관리ToolStripMenuItem.Text = "관리";
            // 
            // menuItem_Log
            // 
            this.menuItem_Log.Name = "menuItem_Log";
            this.menuItem_Log.Size = new System.Drawing.Size(239, 34);
            this.menuItem_Log.Text = "로그감시";
            this.menuItem_Log.Click += new System.EventHandler(this.로그감시ToolStripMenuItem_Click);
            // 
            // 계좌관리ToolStripMenuItem
            // 
            this.계좌관리ToolStripMenuItem.Name = "계좌관리ToolStripMenuItem";
            this.계좌관리ToolStripMenuItem.Size = new System.Drawing.Size(109, 34);
            this.계좌관리ToolStripMenuItem.Text = "계좌관리";
            // 
            // MenuItem_데이터관리
            // 
            this.MenuItem_데이터관리.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_데이터감시설정,
            this.MenuItem_데이터감시시작,
            this.MenuItem_데이터감시종료});
            this.MenuItem_데이터관리.Name = "MenuItem_데이터관리";
            this.MenuItem_데이터관리.Size = new System.Drawing.Size(130, 34);
            this.MenuItem_데이터관리.Text = "데이터관리";
            // 
            // MenuItem_데이터감시설정
            // 
            this.MenuItem_데이터감시설정.Name = "MenuItem_데이터감시설정";
            this.MenuItem_데이터감시설정.Size = new System.Drawing.Size(251, 34);
            this.MenuItem_데이터감시설정.Text = "설정";
            this.MenuItem_데이터감시설정.Click += new System.EventHandler(this.MenuItem_데이터감시설정_Click);
            // 
            // MenuItem_데이터감시시작
            // 
            this.MenuItem_데이터감시시작.Name = "MenuItem_데이터감시시작";
            this.MenuItem_데이터감시시작.Size = new System.Drawing.Size(251, 34);
            this.MenuItem_데이터감시시작.Text = "데이터감시시작";
            this.MenuItem_데이터감시시작.Click += new System.EventHandler(this.MenuItem_데이터감시시작_Click);
            // 
            // MenuItem_데이터감시종료
            // 
            this.MenuItem_데이터감시종료.Name = "MenuItem_데이터감시종료";
            this.MenuItem_데이터감시종료.Size = new System.Drawing.Size(251, 34);
            this.MenuItem_데이터감시종료.Text = "데이터감시종료";
            this.MenuItem_데이터감시종료.Click += new System.EventHandler(this.MenuItem_데이터감시종료_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 800);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "SJRobo";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_로그인;
        private System.Windows.Forms.ToolStripMenuItem 관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuItem_Log;
        private System.Windows.Forms.ToolStripMenuItem 계좌관리ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_데이터관리;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_데이터감시설정;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_데이터감시시작;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_데이터감시종료;
    }
}

