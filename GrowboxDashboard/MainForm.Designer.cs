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
            this.connection_settings = new System.Windows.Forms.Button();
            this.manage_btn = new System.Windows.Forms.Button();
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
            this.panelMenu.Controls.Add(this.connection_settings);
            this.panelMenu.Controls.Add(this.manage_btn);
            this.panelMenu.Controls.Add(this.panel3);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(238, 541);
            this.panelMenu.TabIndex = 0;
            // 
            // connection_settings
            // 
            this.connection_settings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connection_settings.Dock = System.Windows.Forms.DockStyle.Top;
            this.connection_settings.FlatAppearance.BorderSize = 0;
            this.connection_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connection_settings.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.connection_settings.ForeColor = System.Drawing.Color.Gainsboro;
            this.connection_settings.Location = new System.Drawing.Point(0, 188);
            this.connection_settings.Name = "connection_settings";
            this.connection_settings.Size = new System.Drawing.Size(238, 60);
            this.connection_settings.TabIndex = 2;
            this.connection_settings.Text = "Подключение";
            this.connection_settings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.connection_settings.UseVisualStyleBackColor = true;
            this.connection_settings.Click += new System.EventHandler(this.connection_settings_Click);
            // 
            // manage_btn
            // 
            this.manage_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manage_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.manage_btn.FlatAppearance.BorderSize = 0;
            this.manage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manage_btn.Font = new System.Drawing.Font("Segoe UI Semilight", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.manage_btn.ForeColor = System.Drawing.Color.Gainsboro;
            this.manage_btn.Location = new System.Drawing.Point(0, 128);
            this.manage_btn.Name = "manage_btn";
            this.manage_btn.Size = new System.Drawing.Size(238, 60);
            this.manage_btn.TabIndex = 1;
            this.manage_btn.Text = "Управление";
            this.manage_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.manage_btn.UseVisualStyleBackColor = true;
            this.manage_btn.Click += new System.EventHandler(this.manage_btn_Click);
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
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(52, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
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
        private Button manage_btn;
        private Panel panel3;
        private Label label1;
        private Button connection_settings;
    }
}