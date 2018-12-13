namespace Voter_ID_Card_Management
{
    partial class appbody
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
            this.Log_in_timer = new System.Windows.Forms.Timer(this.components);
            this.titlebar = new System.Windows.Forms.Panel();
            this.SlidingPanel_Timer = new System.Windows.Forms.Timer(this.components);
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.Settings = new System.Windows.Forms.Button();
            this.Constituency = new System.Windows.Forms.Button();
            this.Address = new System.Windows.Forms.Button();
            this.MandatoryDetails = new System.Windows.Forms.Button();
            this.SlidindPanel_ToggleButton = new System.Windows.Forms.Button();
            this.logoffbutton = new System.Windows.Forms.Button();
            this.minimizebutton = new System.Windows.Forms.Button();
            this.closebutton = new System.Windows.Forms.Button();
            this.ContentPannel = new System.Windows.Forms.Panel();
            this.titlebar.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_in_timer
            // 
            this.Log_in_timer.Interval = 50;
            this.Log_in_timer.Tick += new System.EventHandler(this.Log_in_timer_Tick);
            // 
            // titlebar
            // 
            this.titlebar.BackColor = System.Drawing.Color.Blue;
            this.titlebar.Controls.Add(this.logoffbutton);
            this.titlebar.Controls.Add(this.minimizebutton);
            this.titlebar.Controls.Add(this.closebutton);
            this.titlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlebar.ForeColor = System.Drawing.Color.Blue;
            this.titlebar.Location = new System.Drawing.Point(20, 0);
            this.titlebar.Name = "titlebar";
            this.titlebar.Size = new System.Drawing.Size(1297, 48);
            this.titlebar.TabIndex = 0;
            this.titlebar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.titlebar_MouseDown);
            // 
            // SlidingPanel_Timer
            // 
            this.SlidingPanel_Timer.Interval = 10;
            this.SlidingPanel_Timer.Tick += new System.EventHandler(this.SlidingPanel_Timer_Tick);
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SlidingPanel.BackgroundImage = global::Voter_ID_Card_Management.Properties.Resources.Blue_Wallpaper_colors_34503018_1920_1200;
            this.SlidingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlidingPanel.Controls.Add(this.Settings);
            this.SlidingPanel.Controls.Add(this.Constituency);
            this.SlidingPanel.Controls.Add(this.Address);
            this.SlidingPanel.Controls.Add(this.MandatoryDetails);
            this.SlidingPanel.Controls.Add(this.SlidindPanel_ToggleButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(20, 48);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(300, 690);
            this.SlidingPanel.TabIndex = 1;
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.Color.Transparent;
            this.Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Settings.Image = global::Voter_ID_Card_Management.Properties.Resources.settings;
            this.Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Settings.Location = new System.Drawing.Point(0, 384);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Settings.Size = new System.Drawing.Size(300, 101);
            this.Settings.TabIndex = 6;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = false;
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // Constituency
            // 
            this.Constituency.BackColor = System.Drawing.Color.Transparent;
            this.Constituency.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Constituency.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Constituency.Image = global::Voter_ID_Card_Management.Properties.Resources.vote1;
            this.Constituency.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Constituency.Location = new System.Drawing.Point(0, 286);
            this.Constituency.Name = "Constituency";
            this.Constituency.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Constituency.Size = new System.Drawing.Size(300, 101);
            this.Constituency.TabIndex = 5;
            this.Constituency.Text = "Constituency";
            this.Constituency.UseVisualStyleBackColor = false;
            this.Constituency.Click += new System.EventHandler(this.Constituency_Click);
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.Transparent;
            this.Address.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.Image = global::Voter_ID_Card_Management.Properties.Resources.add1;
            this.Address.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Address.Location = new System.Drawing.Point(0, 191);
            this.Address.Name = "Address";
            this.Address.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Address.Size = new System.Drawing.Size(300, 101);
            this.Address.TabIndex = 4;
            this.Address.Text = "Address";
            this.Address.UseVisualStyleBackColor = false;
            this.Address.Click += new System.EventHandler(this.Address_Click);
            // 
            // MandatoryDetails
            // 
            this.MandatoryDetails.BackColor = System.Drawing.Color.Transparent;
            this.MandatoryDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MandatoryDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MandatoryDetails.Image = global::Voter_ID_Card_Management.Properties.Resources.person2;
            this.MandatoryDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MandatoryDetails.Location = new System.Drawing.Point(0, 96);
            this.MandatoryDetails.Name = "MandatoryDetails";
            this.MandatoryDetails.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.MandatoryDetails.Size = new System.Drawing.Size(300, 101);
            this.MandatoryDetails.TabIndex = 3;
            this.MandatoryDetails.Text = "Mandatory Details";
            this.MandatoryDetails.UseVisualStyleBackColor = false;
            this.MandatoryDetails.Click += new System.EventHandler(this.MandatoryDetails_Click);
            // 
            // SlidindPanel_ToggleButton
            // 
            this.SlidindPanel_ToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.SlidindPanel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidindPanel_ToggleButton.Image = global::Voter_ID_Card_Management.Properties.Resources.leftarr;
            this.SlidindPanel_ToggleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlidindPanel_ToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidindPanel_ToggleButton.Name = "SlidindPanel_ToggleButton";
            this.SlidindPanel_ToggleButton.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.SlidindPanel_ToggleButton.Size = new System.Drawing.Size(300, 101);
            this.SlidindPanel_ToggleButton.TabIndex = 2;
            this.SlidindPanel_ToggleButton.UseVisualStyleBackColor = false;
            this.SlidindPanel_ToggleButton.Click += new System.EventHandler(this.SlidindPanel_ToggleButton_Click);
            // 
            // logoffbutton
            // 
            this.logoffbutton.BackgroundImage = global::Voter_ID_Card_Management.Properties.Resources.logoff;
            this.logoffbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoffbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoffbutton.ForeColor = System.Drawing.Color.Blue;
            this.logoffbutton.Location = new System.Drawing.Point(1153, 3);
            this.logoffbutton.Name = "logoffbutton";
            this.logoffbutton.Size = new System.Drawing.Size(43, 43);
            this.logoffbutton.TabIndex = 2;
            this.logoffbutton.UseVisualStyleBackColor = true;
            this.logoffbutton.Click += new System.EventHandler(this.logoffbutton_Click);
            // 
            // minimizebutton
            // 
            this.minimizebutton.BackgroundImage = global::Voter_ID_Card_Management.Properties.Resources.min;
            this.minimizebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minimizebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizebutton.ForeColor = System.Drawing.Color.Blue;
            this.minimizebutton.Location = new System.Drawing.Point(1202, 2);
            this.minimizebutton.Name = "minimizebutton";
            this.minimizebutton.Size = new System.Drawing.Size(43, 43);
            this.minimizebutton.TabIndex = 2;
            this.minimizebutton.UseVisualStyleBackColor = true;
            this.minimizebutton.Click += new System.EventHandler(this.minimizebutton_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackgroundImage = global::Voter_ID_Card_Management.Properties.Resources.close2;
            this.closebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.ForeColor = System.Drawing.Color.Blue;
            this.closebutton.Location = new System.Drawing.Point(1251, 3);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(43, 43);
            this.closebutton.TabIndex = 1;
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // ContentPannel
            // 
            this.ContentPannel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPannel.Location = new System.Drawing.Point(326, 48);
            this.ContentPannel.Name = "ContentPannel";
            this.ContentPannel.Size = new System.Drawing.Size(991, 690);
            this.ContentPannel.TabIndex = 2;
            // 
            // appbody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 738);
            this.Controls.Add(this.ContentPannel);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.titlebar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "appbody";
            this.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.Text = "azzsfxz";
            this.Load += new System.EventHandler(this.appbody_Load);
            this.titlebar.ResumeLayout(false);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_timer;
        private System.Windows.Forms.Panel titlebar;
        private System.Windows.Forms.Button logoffbutton;
        private System.Windows.Forms.Button minimizebutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidindPanel_ToggleButton;
        private System.Windows.Forms.Timer SlidingPanel_Timer;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button Constituency;
        private System.Windows.Forms.Button Address;
        private System.Windows.Forms.Button MandatoryDetails;
        private System.Windows.Forms.Panel ContentPannel;
    }
}