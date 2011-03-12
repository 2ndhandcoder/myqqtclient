namespace QQTClient
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageHome = new System.Windows.Forms.TabPage();
            this.tabPageMsg = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPageProfile = new System.Windows.Forms.TabPage();
            this.imageListTab = new System.Windows.Forms.ImageList(this.components);
            this.账号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.在线帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.menuMain.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.账号ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(397, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuStrip1";
            // 
            // tabMain
            // 
            this.tabMain.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabMain.Controls.Add(this.tabPageHome);
            this.tabMain.Controls.Add(this.tabPageMsg);
            this.tabMain.Controls.Add(this.tabPage3);
            this.tabMain.Controls.Add(this.tabPageProfile);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.ImageList = this.imageListTab;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(397, 349);
            this.tabMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabMain.TabIndex = 1;
            // 
            // tabPageHome
            // 
            this.tabPageHome.ImageIndex = 2;
            this.tabPageHome.Location = new System.Drawing.Point(4, 34);
            this.tabPageHome.Name = "tabPageHome";
            this.tabPageHome.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHome.Size = new System.Drawing.Size(389, 311);
            this.tabPageHome.TabIndex = 0;
            this.tabPageHome.UseVisualStyleBackColor = true;
            // 
            // tabPageMsg
            // 
            this.tabPageMsg.ImageIndex = 1;
            this.tabPageMsg.Location = new System.Drawing.Point(4, 34);
            this.tabPageMsg.Name = "tabPageMsg";
            this.tabPageMsg.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMsg.Size = new System.Drawing.Size(389, 311);
            this.tabPageMsg.TabIndex = 1;
            this.tabPageMsg.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.ImageIndex = 3;
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(389, 311);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPageProfile
            // 
            this.tabPageProfile.ImageIndex = 0;
            this.tabPageProfile.Location = new System.Drawing.Point(4, 34);
            this.tabPageProfile.Name = "tabPageProfile";
            this.tabPageProfile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfile.Size = new System.Drawing.Size(389, 311);
            this.tabPageProfile.TabIndex = 3;
            this.tabPageProfile.UseVisualStyleBackColor = true;
            // 
            // imageListTab
            // 
            this.imageListTab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListTab.ImageStream")));
            this.imageListTab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListTab.Images.SetKeyName(0, "Contact.png");
            this.imageListTab.Images.SetKeyName(1, "E-Mail.png");
            this.imageListTab.Images.SetKeyName(2, "Home.png");
            this.imageListTab.Images.SetKeyName(3, "WinAmp.png");
            // 
            // 账号ToolStripMenuItem
            // 
            this.账号ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录ToolStripMenuItem,
            this.注销ToolStripMenuItem,
            this.toolStripSeparator1,
            this.退出ToolStripMenuItem});
            this.账号ToolStripMenuItem.Image = global::QQTClient.Properties.Resources.MSN;
            this.账号ToolStripMenuItem.Name = "账号ToolStripMenuItem";
            this.账号ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.账号ToolStripMenuItem.Text = "账号";
            // 
            // 登录ToolStripMenuItem
            // 
            this.登录ToolStripMenuItem.Image = global::QQTClient.Properties.Resources.Lock;
            this.登录ToolStripMenuItem.Name = "登录ToolStripMenuItem";
            this.登录ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.登录ToolStripMenuItem.Text = "登录";
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Image = global::QQTClient.Properties.Resources.Power;
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.注销ToolStripMenuItem.Text = "注销";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(95, 6);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Image = global::QQTClient.Properties.Resources.Xion;
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem,
            this.在线帮助ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Image = global::QQTClient.Properties.Resources.IE;
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Image = global::QQTClient.Properties.Resources.Lightbulb;
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.关于ToolStripMenuItem.Text = "关于...";
            // 
            // 在线帮助ToolStripMenuItem
            // 
            this.在线帮助ToolStripMenuItem.Name = "在线帮助ToolStripMenuItem";
            this.在线帮助ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.在线帮助ToolStripMenuItem.Text = "在线帮助";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 373);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageHome;
        private System.Windows.Forms.TabPage tabPageMsg;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPageProfile;
        private System.Windows.Forms.ToolStripMenuItem 账号ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 在线帮助ToolStripMenuItem;
        private System.Windows.Forms.ImageList imageListTab;
    }
}

