namespace GrowboxDashboard
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.settingsBtn = new FontAwesome.Sharp.IconButton();
            this.manageBtn = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.main_panel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.panelMenu.Controls.Add(this.settingsBtn);
            this.panelMenu.Controls.Add(this.manageBtn);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 541);
            this.panelMenu.TabIndex = 0;
            // 
            // settingsBtn
            // 
            this.settingsBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.settingsBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.settingsBtn.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            this.settingsBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.settingsBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.settingsBtn.IconSize = 30;
            this.settingsBtn.Location = new System.Drawing.Point(0, 188);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(238, 60);
            this.settingsBtn.TabIndex = 4;
            this.settingsBtn.Text = "Настройки";
            this.settingsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.settingsBtn.UseVisualStyleBackColor = true;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
            // 
            // manageBtn
            // 
            this.manageBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manageBtn.FlatAppearance.BorderSize = 0;
            this.manageBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageBtn.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manageBtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.manageBtn.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.manageBtn.IconColor = System.Drawing.Color.Gainsboro;
            this.manageBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.manageBtn.IconSize = 30;
            this.manageBtn.Location = new System.Drawing.Point(0, 128);
            this.manageBtn.Name = "manageBtn";
            this.manageBtn.Size = new System.Drawing.Size(238, 60);
            this.manageBtn.TabIndex = 3;
            this.manageBtn.Text = "Управление";
            this.manageBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.manageBtn.UseVisualStyleBackColor = true;
            this.manageBtn.Click += new System.EventHandler(this.manageBtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(34)))), ((int)(((byte)(42)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 128);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(30, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "DASHBOARD";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.main_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_panel.Location = new System.Drawing.Point(238, 0);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(846, 541);
            this.main_panel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 541);
            this.Controls.Add(this.main_panel);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Dashboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelMenu;
        private Panel main_panel;
        private Panel panel3;
        private Label label1;
        private FontAwesome.Sharp.IconButton manageBtn;
        private FontAwesome.Sharp.IconButton settingsBtn;
    }
}