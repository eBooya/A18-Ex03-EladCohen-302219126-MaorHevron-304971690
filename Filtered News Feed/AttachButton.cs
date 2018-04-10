using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of concrete complex product 1 in Builder pattern 
    /// plays the role of the notyfier in Observer pattern
    /// </summary>
    public partial class AttachButton : FilteredFeedFormControl
    {        
        public event Action m_AttachButtonDelegates;
        // c'tor
        public AttachButton(FilteredNewsFeedForm i_Form) : base(i_Form)
        {       
            InitializeComponent();
        }

        private void buttonAttachFriendToFeedGroup_Click(object sender, EventArgs e)
        {
            this.moveFriendToGroup();                       
            notifyObservers();
        }
        
        private void notifyObservers()
        {
            if (m_AttachButtonDelegates != null)
            {
                m_AttachButtonDelegates.Invoke();
            }
        }      

        private void moveFriendToGroup()
        {
               User selectedFriend = this.m_Form.ListBoxFriends.SelectedItem as User;
               if (!this.m_Form.FeedGroups[this.m_Number - 1].ListBoxFeedGroup.Items.Contains(selectedFriend))
               {
                    this.m_Form.FeedGroups[this.m_Number - 1].ListBoxFeedGroup.Items.Add(selectedFriend);
                    this.m_Form.ListBoxFriends.Items.Remove(selectedFriend);
                    this.m_Form.PictureBoxFriend.Image = null;
               }
               else
               {
                    MessageBox.Show(selectedFriend.Name + " already exist in this Feed-Group."); 
               }               
        }
    }
}
