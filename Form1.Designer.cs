namespace YanceySubnetCalculator
{
    partial class mainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSubnet = new System.Windows.Forms.TabPage();
            this.groupBoxStartingNetwork = new System.Windows.Forms.GroupBox();
            this.maskedTextBoxNetworkIP = new System.Windows.Forms.MaskedTextBox();
            this.labelNetworkIPAddress = new System.Windows.Forms.Label();
            this.tabPageSupernetting = new System.Windows.Forms.TabPage();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageSubnet.SuspendLayout();
            this.groupBoxStartingNetwork.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(587, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageSubnet);
            this.tabControlMain.Controls.Add(this.tabPageSupernetting);
            this.tabControlMain.Location = new System.Drawing.Point(0, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(587, 233);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageSubnet
            // 
            this.tabPageSubnet.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSubnet.Controls.Add(this.groupBoxStartingNetwork);
            this.tabPageSubnet.Location = new System.Drawing.Point(4, 22);
            this.tabPageSubnet.Name = "tabPageSubnet";
            this.tabPageSubnet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSubnet.Size = new System.Drawing.Size(579, 207);
            this.tabPageSubnet.TabIndex = 0;
            this.tabPageSubnet.Text = "Subnetting";
            this.tabPageSubnet.Click += new System.EventHandler(this.tabPageSubnet_Click);
            // 
            // groupBoxStartingNetwork
            // 
            this.groupBoxStartingNetwork.Controls.Add(this.maskedTextBoxNetworkIP);
            this.groupBoxStartingNetwork.Controls.Add(this.labelNetworkIPAddress);
            this.groupBoxStartingNetwork.Location = new System.Drawing.Point(6, 6);
            this.groupBoxStartingNetwork.Name = "groupBoxStartingNetwork";
            this.groupBoxStartingNetwork.Size = new System.Drawing.Size(320, 146);
            this.groupBoxStartingNetwork.TabIndex = 0;
            this.groupBoxStartingNetwork.TabStop = false;
            this.groupBoxStartingNetwork.Text = "Starting Network";
            // 
            // maskedTextBoxNetworkIP
            // 
            this.maskedTextBoxNetworkIP.Location = new System.Drawing.Point(19, 39);
            this.maskedTextBoxNetworkIP.Mask = "000\\.000\\.000\\.000";
            this.maskedTextBoxNetworkIP.Name = "maskedTextBoxNetworkIP";
            this.maskedTextBoxNetworkIP.PromptChar = ' ';
            this.maskedTextBoxNetworkIP.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBoxNetworkIP.TabIndex = 1;
            this.maskedTextBoxNetworkIP.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBoxNetworkIP_TypeValidationCompleted);
            this.maskedTextBoxNetworkIP.Enter += new System.EventHandler(this.maskedTextBoxNetworkIP_Enter);
            this.maskedTextBoxNetworkIP.KeyDown += new System.Windows.Forms.KeyEventHandler(this.maskedTextBoxNetworkIP_KeyDown);
            this.maskedTextBoxNetworkIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedTextBoxNetworkIP_KeyPress);
            this.maskedTextBoxNetworkIP.Leave += new System.EventHandler(this.maskedTextBoxNetworkIP_Leave);
            this.maskedTextBoxNetworkIP.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.maskedTextBoxNetworkIP_PreviewKeyDown);
            // 
            // labelNetworkIPAddress
            // 
            this.labelNetworkIPAddress.AutoSize = true;
            this.labelNetworkIPAddress.Location = new System.Drawing.Point(16, 23);
            this.labelNetworkIPAddress.Name = "labelNetworkIPAddress";
            this.labelNetworkIPAddress.Size = new System.Drawing.Size(101, 13);
            this.labelNetworkIPAddress.TabIndex = 0;
            this.labelNetworkIPAddress.Text = "Network IP Address";
            // 
            // tabPageSupernetting
            // 
            this.tabPageSupernetting.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageSupernetting.Location = new System.Drawing.Point(4, 22);
            this.tabPageSupernetting.Name = "tabPageSupernetting";
            this.tabPageSupernetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSupernetting.Size = new System.Drawing.Size(579, 207);
            this.tabPageSupernetting.TabIndex = 1;
            this.tabPageSupernetting.Text = "Supernetting";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 262);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainForm";
            this.Text = "Yancey Subnet Calculator";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSubnet.ResumeLayout(false);
            this.groupBoxStartingNetwork.ResumeLayout(false);
            this.groupBoxStartingNetwork.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSubnet;
        private System.Windows.Forms.TabPage tabPageSupernetting;
        private System.Windows.Forms.GroupBox groupBoxStartingNetwork;
        private System.Windows.Forms.Label labelNetworkIPAddress;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNetworkIP;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

