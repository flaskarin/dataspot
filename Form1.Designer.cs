namespace dataspot_autorun
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtUrl;
        private Button btnInstall;
        private Button btnUninstall;
        private Label lblStatus;
        private Label lblFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtUrl = new TextBox();
            btnInstall = new Button();
            btnUninstall = new Button();       
            lblStatus = new Label();
            lblFooter = new Label();
            lblRights = new Label();
            SuspendLayout();
            // 
            // txtUrl
            // 
            txtUrl.Location = new Point(12, 12);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(360, 23);
            txtUrl.TabIndex = 0;
            txtUrl.Text = "";
            // 
            // btnInstall
            // 
            btnInstall.Location = new Point(12, 50);
            btnInstall.Name = "btnInstall";
            btnInstall.Size = new Size(100, 30);
            btnInstall.TabIndex = 1;
            btnInstall.Text = "Instaliraj";
            btnInstall.UseVisualStyleBackColor = true;
            btnInstall.Click += btnInstall_Click;
            // 
            // btnUninstall
            // 
            btnUninstall.Location = new Point(130, 50);
            btnUninstall.Name = "btnUninstall";
            btnUninstall.Size = new Size(100, 30);
            btnUninstall.TabIndex = 2;
            btnUninstall.Text = "Deinstaliraj";
            btnUninstall.UseVisualStyleBackColor = true;
            btnUninstall.Click += btnUninstall_Click;
            // 
            // lblStatus
            // 
            lblStatus.Location = new Point(12, 90);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(360, 23);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Status...";
            // 
            // lblFooter
            // 
            lblFooter.Location = new Point(0, 0);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(100, 23);
            lblFooter.TabIndex = 0;
            // 
            // lblRights
            // 
            lblRights.AutoSize = true;
            lblRights.Font = new Font("Segoe UI", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lblRights.ForeColor = SystemColors.GrayText;
            lblRights.Location = new Point(221, 90);
            lblRights.Name = "lblRights";
            lblRights.Size = new Size(151, 36);
            lblRights.TabIndex = 4;
            lblRights.Text = "Autorun Application by dataspot\r\nCopyright © 2025 dataspot d.o.o.\r\nAll Rights Reserved";
            // 
            // Form1
            // 
            ClientSize = new Size(384, 131);
            Controls.Add(lblRights);
            Controls.Add(lblStatus);
            Controls.Add(btnUninstall);
            Controls.Add(btnInstall);
            Controls.Add(txtUrl);
            Name = "Form1";
            Text = "Dataspot Autorun Installer";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblRights;
    }
}
