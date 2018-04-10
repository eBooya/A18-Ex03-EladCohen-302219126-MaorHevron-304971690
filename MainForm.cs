using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Facebook;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    public partial class MainForm : Form
    {
        private string m_ApplicationID;
        private LoginResult m_LoginResult = null;
        private User LoggedInUser = null;
        private Dictionary<string, string> m_AppIdDictionary = new Dictionary<string, string>();

        // c'tor
        public MainForm()
        {
            this.CenterToScreen();
            this.InitializeComponent();
            addComboBoxParameters();
            restartScreen();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void addComboBoxParameters()
        {
            addAppIdComboBoxParams();
        }

        private void addAppIdComboBoxParams()
        {
            m_AppIdDictionary.Add("Elad And Maor AppID", "1751593355141985");
            m_AppIdDictionary.Add("Tester AppID", "1450160541956417");
            foreach (KeyValuePair<string, string> entry in m_AppIdDictionary)
            {
                appIdComboBox.Items.Add(entry.Key);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            this.loginAndInit();
            appIdComboBox.Enabled = false;
        }

        private void enable_Buttons()
        {
            buttonZodiacMatchingFeature.Enabled = true;
            buttonFilteredNewsFeedFeature.Enabled = true;
            logoutButton.Enabled = true;
            deletePermissionsCheckBox.Enabled = true;
        }

        private void loginAndInit()
        {
            try
            {
                m_LoginResult = FacebookService.Login(
                    m_ApplicationID, // (elad.cohen.3304's "DP.302219126.304971690" app)
                    "public_profile",
                    "email",
                    "user_friends",
                    "user_events",
                    "user_likes",
                    "user_photos",
                    "user_posts",
                    "user_tagged_places",
                    "rsvp_event",
                    "publish_actions",
                    "user_relationships",
                    "user_hometown",
                    "user_location",
                    "user_birthday");
                if (string.IsNullOrEmpty(m_LoginResult.AccessToken) == false)
                {
                    this.LoggedInUser = m_LoginResult.LoggedInUser;
                    this.fetchUserInfo();
                    enable_Buttons();
                }
                else
                {
                    MessageBox.Show(string.Format(
@"Login Failed !
reason: {0}",
m_LoginResult.ErrorMessage));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format(
@"Login Failed !
reason: {0}",
e.Message));
            }
        }

        private void fetchUserInfo()
        {
            pictureBoxUserMain.LoadAsync(this.LoggedInUser.PictureNormalURL);
            labelChooseFeature.Text = "Hello " + this.LoggedInUser.FirstName + "! Please choose:";
        }

        private void zodiacMatchingFeatureButton_Click(object sender, EventArgs e)
        {
            Form zodiacMatchingForm = new ZodiacMatchingForm(this.LoggedInUser);
            zodiacMatchingForm.ShowDialog();
        }

        private void filteredNewsFeedButton_Click(object sender, EventArgs e)
        {
            Form filteredNewsFeedForm = new FilteredNewsFeedForm(this.LoggedInUser);
            filteredNewsFeedForm.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (this.LoggedInUser != null)
            {
                FacebookService.Logout(new Action(this.restartScreen));
                MessageBox.Show("You are logged out !");
                if(deletePermissionsCheckBox.Checked == true)
                {
                    deletePermissions();
                }
            }
        }

        private void restartScreen()
        {
            pictureBoxUserMain.Image = null;
            labelChooseFeature.Text = "Hello";
            appIdComboBox.Text = "Choose Application ID";
            disable_Buttons();
            appIdComboBox.Enabled = true;
            resetDeletePermissionsCheckBox();
        }

        private void disable_Buttons()
        {
            loginButton.Enabled = false;
            buttonZodiacMatchingFeature.Enabled = false;
            buttonFilteredNewsFeedFeature.Enabled = false;
            logoutButton.Enabled = false;
        }

        private void resetDeletePermissionsCheckBox()
        {
            deletePermissionsCheckBox.Checked = false;
            deletePermissionsCheckBox.Enabled = false;
        }

        private void deletePermissions()
        {
            try
            {
                var fb = new FacebookClient(m_LoginResult.AccessToken);
                var res = fb.Delete("me/permissions");
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format(
@"Error detected while trying delete permissions !
reason: {0}",
e.Message));
            }
        }

        private void appIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string AppIdDictionaryKey = appIdComboBox.SelectedItem.ToString();
            m_ApplicationID = m_AppIdDictionary[AppIdDictionaryKey];
            loginButton.Enabled = true;
        }
    }
}
