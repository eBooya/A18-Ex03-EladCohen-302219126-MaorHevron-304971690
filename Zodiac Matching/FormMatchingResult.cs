using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// Form that display the love compatibility (Matching Result) result between the user with selected friend by zodiac sign
    /// </summary>
    public partial class FormMatchingResult : Form
    {
        public User LoggedInUser { get; set; }

        public User UserFriend { get; set; }

        public FormMatchingResult()
        {
            InitializeComponent();
        }

        public void setMatchingResultToTextBox(string i_MatchingSummary, string i_MatchingPercents)
        {
            textBoxMatchingSummary.Text = i_MatchingSummary;
            labelSetMatchingPercents.Text = i_MatchingPercents;
        }

        public void setLoggedInUserInfo()
        {
            string UserZodiacSign = LoggedInUser.getZodiacSign();
            setLoggedInUserPicture(LoggedInUser.PictureNormalURL);
            setLoggedInUserZodiacSign(UserZodiacSign);
        }

        private void setLoggedInUserZodiacSign(string i_UserZodiacSign)
        {
            labelUserZodiacSign.Text = i_UserZodiacSign;
        }

        private void setLoggedInUserPicture(string i_UserPictureNormalUrl)
        {
            pictureBoxLoggedInUser.LoadAsync(i_UserPictureNormalUrl);
        }

        public void setFriendInfo()
        {
            string FriendZodiacSign = UserFriend.getZodiacSign();
            string IsraeliFormatFriendBirthday = getIsraeliFormatFriendBirthday();
            labelFriendName.Text = UserFriend.Name;
            labelSetBirthday.Text = string.Format("{0} - israeli format", IsraeliFormatFriendBirthday) ?? "hasn't exposed";
            labelSetGender.Text = UserFriend.Gender.ToString() ?? "hasn't exposed";
            labelSetZodiacSign.Text = FriendZodiacSign ?? "hasn't exposed"; // display zodiac sign in basic info
            labelSetRelationshipStatus.Text = UserFriend.RelationshipStatus.ToString() ?? "hasn't exposed";
            labelCity.Text = UserFriend.Location.Name ?? "hasn't exposed";
            labelFriendZodiacSign.Text = FriendZodiacSign ?? "hasn't exposed"; // display zodiac sign under friend's picture
            setFriendPicture(UserFriend.PictureNormalURL);
        }

        private string getIsraeliFormatFriendBirthday()
        {
            DateTime FriendBirthday = ZodiacSign.getUserBirthdayAsDateTimeType(UserFriend);
            string IsraelFormatFriendBirthday = FriendBirthday.Day + "/" + FriendBirthday.Month;
            return IsraelFormatFriendBirthday;
        }

        public void setFriendPicture(string i_FriendPictureNormalUrl)
        {
            pictureBoxFriend.LoadAsync(i_FriendPictureNormalUrl);
        }

        private void postMatchingResultFormToFacebookWall()
        {
            try
            {
                saveWindowsFormAsAPicture();
                LoggedInUser.PostPhoto("FormMatchingResult.jpg", "Mathching Result", "Mathching Result", null);
                MessageBox.Show("Matching Result has been successfully uploaded");
            }
            catch(Exception e)
            {
                MessageBox.Show(string.Format(
@"Error detected while trying post to facebook wall !
Please try again later..
reason: {0}",
e.Message));
            }
        }

        private void saveWindowsFormAsAPicture()
        {
            using (Graphics gfx = this.CreateGraphics())
            {
                using (Bitmap bmp = new Bitmap(this.Width, this.Height, gfx))
                {
                    this.Invoke(new Action(() => this.DrawToBitmap(bmp, new Rectangle(0, 0, this.Width, this.Height))));
                    bmp.Save("FormMatchingResult.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
        }

        public void SetScreenToCenter()
        {
            this.CenterToScreen();
        }

        private void buttonShareToWall_Click(object sender, EventArgs e)
        {
            new Thread(postMatchingResultFormToFacebookWall).Start();
        }
    }
}
