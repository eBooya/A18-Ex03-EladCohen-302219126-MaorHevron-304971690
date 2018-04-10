using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    public partial class Feed : FilteredFeedFormControl
    {
        /// <summary>
        /// plays the role of concrete complex product 3 in Builder pattern 
        /// </summary>
        public static int s_PhotoIndex = 0;
        public List<Photo> m_Photos = new List<Photo>();
        // c'tor
        public Feed(FilteredNewsFeedForm i_Form) : base(i_Form)
        {
            this.InitializeComponent();
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.ListBoxFriendsFeed.SelectedItems.Count == 1)
            {
                User selectedFriend = ListBoxFriendsFeed.SelectedItem as User;
                this.PictureBoxFriendFeed.LoadAsync(selectedFriend.PictureNormalURL);
                this.ButtonFriendRemove.Enabled = true;
            }
        }

        private void buttonFriendRemove_Click(object sender, EventArgs e)
        {
            this.RemoveFriendFromFeed();
            this.ButtonFriendRemove.Enabled = false;
        }

        private void RemoveFriendFromFeed()
        {
            User selectedFriend = this.ListBoxFriendsFeed.SelectedItem as User;
            FeedGroup attachedFeedGroup = this.m_Form.FeedGroups[this.m_Number - 1];

            this.m_Form.ListBoxFriends.Items.Add(selectedFriend); // Add to Form friend list
            attachedFeedGroup.ListBoxFeedGroup.Items.Remove(selectedFriend); // Remove from attached FeedGroup friend list
            attachedFeedGroup.m_FeedBuilder.SetSettings();
            attachedFeedGroup.TextBoxFeedGroup.Text = string.Empty;
            this.PictureBoxFriendFeed.Image = null;
            if (this.ListBoxFriendsFeed.Items.Count == 0)
            {
                this.m_Form.TabControl.TabPages.Remove(this.m_Form.TabControl.TabPages[this.m_Number]);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.backToHomepage();
        }

        private void backToHomepage()
        {
            this.m_Form.TabControl.SelectedTab = this.m_Form.TabPage1;
        }
        
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (s_PhotoIndex < this.m_Photos.Count)
            {
                this.PictureBoxPhotosFeed.LoadAsync(this.m_Photos[s_PhotoIndex].PictureNormalURL);
                s_PhotoIndex++;
            }
            else
            {
                MessageBox.Show("Feed friends havent poste new photos in the last 20 days." );
            }
        }

        private void listBoxEvents_SelectedIndexChanged(object sender, EventArgs e)// Shows attending friends to an event
        {
            List<User> attendingFriends = new List<User>();
            Event fbEvent = ListBoxEventsFeed.SelectedItem as Event;
            string sAttending = string.Empty;

            foreach (User friend in fbEvent.AttendingUsers)
            {
                foreach (User feedFriend in ListBoxFriendsFeed.Items)
                {
                    if (feedFriend.Name == friend.Name)
                    {
                        attendingFriends.Add(friend);
                    }
                }
            }

            foreach (User friend in attendingFriends)
            {
                sAttending += friend.Name + ",\n";
            }

            if (sAttending != string.Empty)
            {
                sAttending += "is Attending\n";
                MessageBox.Show(sAttending);
            }
        }

        private void buttonCreateBirthdayFileFeed_Click(object sender, EventArgs e)
        {
            StringBuilder text = new StringBuilder();
            text.AppendFormat("{0} Feed Birthdays:", this.m_Form.FeedGroups[this.m_Number - 1].TextBoxFeedGroup.Text);
            text.AppendLine();
            foreach (User friend in ListBoxFriendsFeed.Items)
            {
                text.Append(friend.Name);
                text.Append(" ");
                text.Append(friend.Birthday);
                text.AppendLine();
            }

            try
            {
                System.IO.File.WriteAllText(@"F:\Feed Birthdays Dates.txt", text.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("System encountered a problem saving this File:" + ex);
            }
        }

        // Send Email from user account to attending friends accounts 
        private void buttonSendMailFeed_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage("elicoco22@gmail.com", "maorhevron1@gmail.com");
                mail.Subject = "Mutual Events Attending Friends";
                mail.Body = "Hey, im also going to <EventName> Event at <EventDate>. Ill be happy to meet you there";
                SmtpClient SmtpServer = new SmtpClient();
                SmtpServer.Port = 587;
                SmtpServer.DeliveryMethod = SmtpDeliveryMethod.Network;
                SmtpServer.UseDefaultCredentials = false;
                SmtpServer.EnableSsl = true;
                SmtpServer.Timeout = 10000;
                SmtpServer.Host = "smtp.googlemail.com";
                SmtpServer.Credentials = new System.Net.NetworkCredential("elicoco22@gmail.com", "qazw1234");
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                SmtpServer.Send(mail);
                MessageBox.Show("Mail Sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
