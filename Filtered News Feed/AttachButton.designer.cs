namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    public partial class AttachButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ButtonAttachFriendToFeedGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAttachFriendToFeedGroup
            // 
            this.ButtonAttachFriendToFeedGroup.Location = new System.Drawing.Point(0, 0);
            this.ButtonAttachFriendToFeedGroup.Name = "buttonAttachFriendToFeedGroup";
            this.ButtonAttachFriendToFeedGroup.Size = new System.Drawing.Size(60, 30);
            this.ButtonAttachFriendToFeedGroup.TabIndex = 0;
            this.ButtonAttachFriendToFeedGroup.UseVisualStyleBackColor = true;
            this.ButtonAttachFriendToFeedGroup.Click += new System.EventHandler(this.buttonAttachFriendToFeedGroup_Click);
            // 
            // AttachFriendToFeedGroupButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ButtonAttachFriendToFeedGroup);
            this.Name = "AttachFriendToFeedGroupButton";
            this.Size = new System.Drawing.Size(61, 30);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button ButtonAttachFriendToFeedGroup;
    }
}
