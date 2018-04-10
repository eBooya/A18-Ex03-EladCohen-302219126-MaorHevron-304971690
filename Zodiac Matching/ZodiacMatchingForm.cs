using System;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    internal partial class ZodiacMatchingForm : Form
    {
        #region Class Members

        private readonly object sr_WitdrawLock = new object();
        private User LoggedInUser;
        private FacebookObjectCollection<Page> m_LikedPages = new FacebookObjectCollection<Page>();

        #endregion Class Members

        #region Constructor

        public ZodiacMatchingForm(User i_LoggedInUser)
        {
            LoggedInUser = i_LoggedInUser;
            InitializeComponent();
            InitializeScreen();
        }

        #endregion Constructor

        #region Implementations

        private void InitializeScreen()
        {
            this.CenterToScreen();
            disable_Buttons();
            resetControls();
            createComboBoxesFiltersParams();
            fetchUserInfo();
            enable_Buttons();
        }

        private void disable_Buttons()
        {
            fetchLikedPagesButton.Enabled = false;
            selectPageButton.Enabled = false;
            disableSortButtons();
            disableLovecompatibilityButton();
            disableFiltersControls();
        }

        private void disableLovecompatibilityButton()
        {
            loveCompatibilityButton.Enabled = false;
        }

        private void resetControls()
        {
            userNameTextBox.Text = "User Name";
            resetFilters();
        }

        private void resetFilters()
        {
            comboBoxZodiacSigns.Text = "Zodiac Signs";
            comboBoxZodiacSigns.SelectedItem = null;
            comboBoxGender.Text = "Gender";
            comboBoxGender.SelectedItem = null;
            comboBoxRelationShipStatus.Text = "Relationship Status";
            comboBoxRelationShipStatus.SelectedItem = null;
        }

        private void enable_Buttons()
        {
            fetchLikedPagesButton.Enabled = true;
        }

        private void fetchUserInfo()
        {
            string LoggedInUserName = string.Format("You are logged in as {0} {1}", LoggedInUser.FirstName, LoggedInUser.LastName);
            userNameTextBox.Text = LoggedInUserName;
            displayPicture(pictureBoxUserProfile, LoggedInUser);
        }

        private void displayPicture(PictureBox i_PictureBox, OwnerObject i_Source)
        {
            i_PictureBox.LoadAsync(i_Source.PictureNormalURL);
        }

        private void displaySelectedFriendPicture()
        {
            User selectedFriend = listBoxCommonFriends.SelectedItem as User;
            if (selectedFriend != null)
            {
                if (selectedFriend.PictureNormalURL != null)
                {
                    displayPicture(pictureBoxFriend, selectedFriend);
                }
                else
                {
                    pictureBoxFriend.Image = pictureBoxFriend.ErrorImage;
                }
            }
        }

        private void fetchMutualFriends()
        {
            bool ListOfFriendsIsEmpty = true;
            listBoxCommonFriends.Invoke(new Action(() => listBoxCommonFriends.Items.Clear()));
            listBoxCommonFriends.DisplayMember = "Name";
            try
            {
                if (LoggedInUser.Friends.Count != 0)
                {
                    foreach (User friend in LoggedInUser.Friends)
                    {
                        foreach (Page friendLikedPage in friend.LikedPages)
                        {
                            Page selectedItemPage = null;
                            listBoxLikedPages.Invoke(new Action(() => selectedItemPage = listBoxLikedPages.SelectedItem as Page));
                            if (friendLikedPage.Name == selectedItemPage.Name)
                            {
                                ListOfFriendsIsEmpty = false;
                                FetchFriendsAccordingToFilters(friend);
                                break;
                            }
                        }
                    }
                }

                if (ListOfFriendsIsEmpty == false)
                {
                    enableFiltersControls();
                }
                else
                {
                    MessageBox.Show("No Friends to retrieve :(");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format(
@"Error while trying to fetch the Mutual Friends !
reason: {0}",
e.Message));
            }
        }

        private void fetchLikedPages()
        {
            try
            {
                m_LikedPages = LoggedInUser.LikedPages;
                listBoxLikedPages.Invoke(new Action(() => pageBindingSource.DataSource = m_LikedPages));
                enableSortButtons();
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format(
@"Error while trying to fetch Liked Pages !
reason: {0}",
e.Message));
            }
        }

        private void enableSortButtons()
        {
            sortDescLexicography.Invoke(new Action(() => sortDescLexicography.Enabled = true));
            sortAscLexicography.Invoke(new Action(() => sortAscLexicography.Enabled = true));
        }

        private void disableSortButtons()
        {
            sortAscLexicography.Enabled = false;
            sortDescLexicography.Enabled = false;
        }

        private void FetchFriendsAccordingToFilters(User friend)
        {
            bool isNoFiltersApplied = false;
            bool isFriendPassedTheFilters = false;
            isNoFiltersApplied = checksIfNoFiltersApplied();
            isFriendPassedTheFilters = checksIfFriendMatchingToFilters(friend);
            if (isNoFiltersApplied == true || isFriendPassedTheFilters == true)
            {
                listBoxCommonFriends.Invoke(new Action(() => listBoxCommonFriends.Items.Add(friend)));
            }
        }

        private bool checksIfNoFiltersApplied()
        {
            bool isComboBoxGenderChanged = checkIfComboBoxFilterChange(comboBoxGender);
            bool isComboBoxZodiacSignChanged = checkIfComboBoxFilterChange(comboBoxZodiacSigns);
            bool isComboBoxRelationShipStatusChanged = checkIfComboBoxFilterChange(comboBoxRelationShipStatus);
            if (!isComboBoxGenderChanged && !isComboBoxZodiacSignChanged && !isComboBoxRelationShipStatusChanged)
            {
                return true;
            }

            return false;
        }

        private bool checkIfComboBoxFilterChange(ComboBox i_ComboBox)
        {
            bool isComboBoxChanged = false;
            comboBoxGender.Invoke(new Action(() =>
            {
                if (i_ComboBox.SelectedItem == null)
                {
                    isComboBoxChanged = false;
                }
                else
                {
                    isComboBoxChanged = true;
                }
            }));

            return isComboBoxChanged;
        }

        private bool checksIfFriendMatchingToFilters(User i_Friend)
        {
            object SelectedGender = null;
            object SelectedZodiac = null;
            object SelectedRelationship = null;
            string FriendGender = i_Friend.Gender.ToString();
            string FriendRelationshipStatus = i_Friend.RelationshipStatus.ToString();
            string FriendZodiacSign = i_Friend.getZodiacSign();
            comboBoxGender.Invoke(new Action(() => SelectedGender = comboBoxGender.SelectedItem));
            comboBoxZodiacSigns.Invoke(new Action(() => SelectedZodiac = comboBoxZodiacSigns.SelectedItem));
            comboBoxRelationShipStatus.Invoke(new Action(() => SelectedRelationship = comboBoxRelationShipStatus.SelectedItem));
            if (SelectedGender == null || FriendGender == SelectedGender.ToString())
            {
                if (SelectedRelationship == null || FriendRelationshipStatus == SelectedRelationship.ToString())
                {
                    if (SelectedZodiac == null || FriendZodiacSign == SelectedZodiac.ToString())
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void disableFiltersControls()
        {
            comboBoxGender.Enabled = false;
            comboBoxRelationShipStatus.Enabled = false;
            comboBoxZodiacSigns.Enabled = false;
            resetFiltersButton.Enabled = false;
            applyFiltersButton.Enabled = false;
        }

        private void enableFiltersControls()
        {
            comboBoxGender.Invoke(new Action(() => comboBoxGender.Enabled = true));
            comboBoxRelationShipStatus.Invoke(new Action(() => comboBoxRelationShipStatus.Enabled = true));
            comboBoxZodiacSigns.Invoke(new Action(() => comboBoxZodiacSigns.Enabled = true));
            applyFiltersButton.Invoke(new Action(() => applyFiltersButton.Enabled = true));
            resetFiltersButton.Invoke(new Action(() => resetFiltersButton.Enabled = true));
        }

        private void displayMatchingResultForm()
        {
            try
            {
                User SelectedFriend = listBoxCommonFriends.SelectedItem as User;
                MatchingResultFormManager MatchingResultManager = MatchingResultFormManager.GetInstanse(LoggedInUser);
                MatchingResultManager.FriendUser = SelectedFriend;
                if (SelectedFriend != null)
                {
                    MatchingResultManager.DisplayMatchingResultForm();
                }
                else
                {
                    MessageBox.Show("You didn't select any friend");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format(
@"Error detected: {0}", e.Message));
            }
        }

        private void createComboBoxesFiltersParams()
        {
            comboBoxGender = ComboBoxFiltersFactory.CreateFilter(comboBoxGender);
            comboBoxRelationShipStatus = ComboBoxFiltersFactory.CreateFilter(comboBoxRelationShipStatus);
            comboBoxZodiacSigns = ComboBoxFiltersFactory.CreateFilter(comboBoxZodiacSigns);
        }

        private Page[] initArrayForSort()
        {
            Page[] PagesArray = new Page[listBoxLikedPages.Items.Count];
            int i = 0;
            foreach (Page page in listBoxLikedPages.Items)
            {
                PagesArray[i] = page;
                i++;
            }

            return PagesArray;
        }

        private void sortAscLexicography_Click(object sender, EventArgs e)
        {
            Page[] PagesArray = initArrayForSort();
            LikedPagesSorter AscSorter = new LikedPagesSorter(new AscComparer());
            AscSorter.Sort(PagesArray);
            listBoxLikedPages.DataSource = PagesArray;
        }

        private void sortDescLexicography_Click(object sender, EventArgs e)
        {
            Page[] PagesArray = initArrayForSort();
            LikedPagesSorter DescSorter = new LikedPagesSorter(new DescComparer());
            DescSorter.Sort(PagesArray);
            listBoxLikedPages.DataSource = PagesArray;
        }
        #endregion Implementations

        #region Events Handlers

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            InitializeScreen();
        }

        private void fetchLikedPages_Click(object sender, EventArgs e)
        {
            new Thread(fetchLikedPages).Start();
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectPageButton.Enabled = true;
            disableFiltersControls();
        }

        private void listBoxCommonFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCommonFriends.SelectedItem != null)
            {
                displaySelectedFriendPicture();
                labelFriendPicture.Text = (listBoxCommonFriends.SelectedItem as User).Name;
                loveCompatibilityButton.Enabled = true;
            }
        }

        private void selectPageButton_Click(object sender, EventArgs e)
        {
            if (listBoxLikedPages.SelectedItem == null)
            {
                MessageBox.Show("First you have to choose a page");
            }
            else
            {
                new Thread(fetchMutualFriends).Start();
            }

            resetFilters();
            loveCompatibilityButton.Enabled = false;
        }

        private void resetFiltersButton_Click(object sender, EventArgs e)
        {
            resetFilters();
        }

        private void applyFiltersButton_Click(object sender, EventArgs e)
        {
            fetchMutualFriends();
            listBoxCommonFriends.SelectedItem = null;
            loveCompatibilityButton.Enabled = false;
        }

        private void lovecompatibilityButton_Click(object sender, EventArgs e)
        {
            displayMatchingResultForm();
        }

        #endregion Events Handlers
    }
}
