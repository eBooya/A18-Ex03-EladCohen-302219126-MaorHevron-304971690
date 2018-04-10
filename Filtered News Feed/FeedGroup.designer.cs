namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    public partial class FeedGroup
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelFeedGroup = new System.Windows.Forms.Label();
            this.TextBoxFeedGroup = new System.Windows.Forms.TextBox();
            this.ListBoxFeedGroup = new System.Windows.Forms.ListBox();
            this.ButtonRemoveFeedGroup = new System.Windows.Forms.Button();
            this.ButtonBuildFeedFeedGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelFeedGroup
            // 
            this.LabelFeedGroup.AutoSize = true;
            this.LabelFeedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFeedGroup.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LabelFeedGroup.Location = new System.Drawing.Point(3, 0);
            this.LabelFeedGroup.Name = "labelFeedGroup";
            this.LabelFeedGroup.Size = new System.Drawing.Size(122, 25);
            this.LabelFeedGroup.TabIndex = 1;
            this.LabelFeedGroup.Text = "Feed Group:";
            // 
            // textBoxFeedGroup
            // 
            this.TextBoxFeedGroup.Location = new System.Drawing.Point(0, 28);
            this.TextBoxFeedGroup.Name = "textBoxFeedGroup";
            this.TextBoxFeedGroup.Size = new System.Drawing.Size(199, 26);
            this.TextBoxFeedGroup.TabIndex = 2;
            // 
            // listBoxFeedGroup
            // 
            this.ListBoxFeedGroup.FormattingEnabled = true;
            this.ListBoxFeedGroup.ItemHeight = 20;
            this.ListBoxFeedGroup.Location = new System.Drawing.Point(0, 60);
            this.ListBoxFeedGroup.Name = "listBoxFeedGroup";
            this.ListBoxFeedGroup.Size = new System.Drawing.Size(199, 324);
            this.ListBoxFeedGroup.TabIndex = 3;
            this.ListBoxFeedGroup.SelectedIndexChanged += new System.EventHandler(this.listBoxFeedGroup_SelectedIndexChanged);
            // 
            // buttonRemoveFeedGroup
            // 
            this.ButtonRemoveFeedGroup.AutoSize = true;
            this.ButtonRemoveFeedGroup.Enabled = false;
            this.ButtonRemoveFeedGroup.Location = new System.Drawing.Point(0, 390);
            this.ButtonRemoveFeedGroup.Name = "buttonRemoveFeedGroup";
            this.ButtonRemoveFeedGroup.Size = new System.Drawing.Size(44, 35);
            this.ButtonRemoveFeedGroup.TabIndex = 6;
            this.ButtonRemoveFeedGroup.Text = "X";
            this.ButtonRemoveFeedGroup.UseVisualStyleBackColor = true;
            this.ButtonRemoveFeedGroup.Click += new System.EventHandler(this.buttonRemoveFeedGroup_Click);
            // 
            // buttonBuildFeedFeedGroup
            // 
            this.ButtonBuildFeedFeedGroup.AutoSize = true;
            this.ButtonBuildFeedFeedGroup.Enabled = false;
            this.ButtonBuildFeedFeedGroup.Location = new System.Drawing.Point(116, 389);
            this.ButtonBuildFeedFeedGroup.Name = "buttonBuildFeedFeedGroup";
            this.ButtonBuildFeedFeedGroup.Size = new System.Drawing.Size(84, 54);
            this.ButtonBuildFeedFeedGroup.TabIndex = 8;
            this.ButtonBuildFeedFeedGroup.Text = "FEED";
            this.ButtonBuildFeedFeedGroup.UseVisualStyleBackColor = true;
            this.ButtonBuildFeedFeedGroup.Click += new System.EventHandler(this.buttonBuildFeedFeedGroup_Click);
            // 
            // FeedGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.ButtonBuildFeedFeedGroup);
            this.Controls.Add(this.ButtonRemoveFeedGroup);
            this.Controls.Add(this.ListBoxFeedGroup);
            this.Controls.Add(this.TextBoxFeedGroup);
            this.Controls.Add(this.LabelFeedGroup);
            this.Name = "FeedGroup";
            this.Size = new System.Drawing.Size(202, 443);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LabelFeedGroup;
        public System.Windows.Forms.TextBox TextBoxFeedGroup;
        public System.Windows.Forms.ListBox ListBoxFeedGroup;
        public System.Windows.Forms.Button ButtonRemoveFeedGroup;
        public System.Windows.Forms.Button ButtonBuildFeedFeedGroup;
    }
}
