namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    public partial class MainForm
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
            this.labelChooseFeature = new System.Windows.Forms.Label();
            this.buttonZodiacMatchingFeature = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.buttonFilteredNewsFeedFeature = new System.Windows.Forms.Button();
            this.pictureBoxUserMain = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.deletePermissionsCheckBox = new System.Windows.Forms.CheckBox();
            this.appIdComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserMain)).BeginInit();
            this.SuspendLayout();
            // 
            // labelChooseFeature
            // 
            this.labelChooseFeature.AutoSize = true;
            this.labelChooseFeature.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.labelChooseFeature.Location = new System.Drawing.Point(244, 178);
            this.labelChooseFeature.Name = "labelChooseFeature";
            this.labelChooseFeature.Size = new System.Drawing.Size(53, 20);
            this.labelChooseFeature.TabIndex = 0;
            this.labelChooseFeature.Text = "Hello! ";
            // 
            // buttonZodiacMatchingFeature
            // 
            this.buttonZodiacMatchingFeature.Enabled = false;
            this.buttonZodiacMatchingFeature.Location = new System.Drawing.Point(206, 228);
            this.buttonZodiacMatchingFeature.Name = "buttonZodiacMatchingFeature";
            this.buttonZodiacMatchingFeature.Size = new System.Drawing.Size(260, 45);
            this.buttonZodiacMatchingFeature.TabIndex = 2;
            this.buttonZodiacMatchingFeature.Text = "Zodiac Matching";
            this.buttonZodiacMatchingFeature.UseVisualStyleBackColor = true;
            this.buttonZodiacMatchingFeature.Click += new System.EventHandler(this.zodiacMatchingFeatureButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(206, 326);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 43);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // buttonFilteredNewsFeedFeature
            // 
            this.buttonFilteredNewsFeedFeature.Enabled = false;
            this.buttonFilteredNewsFeedFeature.Location = new System.Drawing.Point(207, 278);
            this.buttonFilteredNewsFeedFeature.Name = "buttonFilteredNewsFeedFeature";
            this.buttonFilteredNewsFeedFeature.Size = new System.Drawing.Size(260, 42);
            this.buttonFilteredNewsFeedFeature.TabIndex = 4;
            this.buttonFilteredNewsFeedFeature.Text = "Filtered News Feed";
            this.buttonFilteredNewsFeedFeature.UseVisualStyleBackColor = true;
            this.buttonFilteredNewsFeedFeature.Click += new System.EventHandler(this.filteredNewsFeedButton_Click);
            // 
            // pictureBoxUserMain
            // 
            this.pictureBoxUserMain.Location = new System.Drawing.Point(264, 23);
            this.pictureBoxUserMain.Name = "pictureBoxUserMain";
            this.pictureBoxUserMain.Size = new System.Drawing.Size(201, 138);
            this.pictureBoxUserMain.TabIndex = 5;
            this.pictureBoxUserMain.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(14, 12);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(159, 40);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(496, 12);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(159, 40);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // deletePermissionsCheckBox
            // 
            this.deletePermissionsCheckBox.AutoSize = true;
            this.deletePermissionsCheckBox.Location = new System.Drawing.Point(496, 60);
            this.deletePermissionsCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deletePermissionsCheckBox.Name = "deletePermissionsCheckBox";
            this.deletePermissionsCheckBox.Size = new System.Drawing.Size(167, 24);
            this.deletePermissionsCheckBox.TabIndex = 8;
            this.deletePermissionsCheckBox.Text = "delete permissions";
            this.deletePermissionsCheckBox.UseVisualStyleBackColor = true;
            // 
            // appIdComboBox
            // 
            this.appIdComboBox.FormattingEnabled = true;
            this.appIdComboBox.Location = new System.Drawing.Point(14, 95);
            this.appIdComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.appIdComboBox.Name = "appIdComboBox";
            this.appIdComboBox.Size = new System.Drawing.Size(193, 28);
            this.appIdComboBox.TabIndex = 9;
            this.appIdComboBox.Text = "Choose Application ID";
            this.appIdComboBox.SelectedIndexChanged += new System.EventHandler(this.appIdComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "first choose App ID to use";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(668, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.appIdComboBox);
            this.Controls.Add(this.deletePermissionsCheckBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.pictureBoxUserMain);
            this.Controls.Add(this.buttonFilteredNewsFeedFeature);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.buttonZodiacMatchingFeature);
            this.Controls.Add(this.labelChooseFeature);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "Facebook new featurs by Maor & Elad";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUserMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelChooseFeature;
        private System.Windows.Forms.Button buttonZodiacMatchingFeature;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button buttonFilteredNewsFeedFeature;
        private System.Windows.Forms.PictureBox pictureBoxUserMain;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.CheckBox deletePermissionsCheckBox;
        private System.Windows.Forms.ComboBox appIdComboBox;
        private System.Windows.Forms.Label label1;
    }
}