using System;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of concrete Builder 3 in Builder pattern 
    /// </summary>
    public class FeedBuilder : IFilteredFeedFormControlBuilder
    {
        private Feed m_Feed;
        private FilteredNewsFeedForm m_Form;

        public void Build(FilteredNewsFeedForm i_Form)
        {
            m_Feed = new Feed(i_Form);
            m_Form = i_Form;
            this.PopulateFeed();
        }

        public void SetSettings()
        {
            this.m_Feed.AutoSize = true;
            this.m_Feed.BringToFront();
            this.PopulateFeed();
        }

        public void PopulateFeed()
        {
            this.clearListBoxes();
            //// friends listBox                             
            foreach (User friend in this.m_Form.FeedGroups[this.m_Feed.m_Number - 1].ListBoxFeedGroup.Items)
            {
                this.m_Feed.ListBoxFriendsFeed.Items.Add(friend);
            }
                       
            foreach (User friend in this.m_Feed.ListBoxFriendsFeed.Items)
            {
                //// posts listBox
                foreach (Post post in friend.Posts)
                {
                    if (post.CreatedTime >= DateTime.Today.AddDays(-20))
                    {
                        if (post.Message != null)
                        {
                            this.m_Feed.ListBoxPostsFeed.Items.Add(friend.Name + ": " + post.Message);
                        }
                        else if (post.Caption != null)
                        {
                            this.m_Feed.ListBoxPostsFeed.Items.Add(friend.Name + ": " + post.Caption);
                        }
                        else
                        {
                            this.m_Feed.ListBoxPostsFeed.Items.Add(friend.Name + ": " + string.Format("[{0}]", post.Type));
                        }
                    }
                }
                //// photos
                foreach (Photo photo in friend.PhotosTaggedIn)
                {
                    if (photo.CreatedTime >= DateTime.Today.AddDays(-20))
                    {
                        this.m_Feed.m_Photos.Add(photo);
                    }
                }

                if (this.m_Feed.m_Photos.Count > 0)
                {
                    Feed.s_PhotoIndex++;
                    this.m_Feed.PictureBoxPhotosFeed.LoadAsync(this.m_Feed.m_Photos[0].PictureNormalURL);
                }
                //// birthday listBox
                this.m_Feed.ListBoxBirthdaysFeed.Items.Add(friend);
                //// events listBox
                foreach (Event fbEvent in friend.Events)
                {
                    if (!this.m_Feed.ListBoxEventsFeed.Items.Contains(fbEvent) && fbEvent.StartTime > DateTime.Today)
                    {
                        this.m_Feed.ListBoxEventsFeed.Items.Add(fbEvent);
                    }
                }
                //// pages listBox
                foreach (Page page in friend.LikedPages)
                {
                    if (!this.m_Feed.ListBoxEventsFeed.Items.Contains(page))
                    {
                        this.m_Feed.ListBoxPagesFeed.Items.Add(page);
                    }
                }
                //// checkins listBox
                foreach (Checkin checkin in friend.Checkins)
                {
                    if (!this.m_Feed.ListBoxEventsFeed.Items.Contains(checkin))
                    {
                        this.m_Feed.ListBoxCheckinsFeed.Items.Add(checkin.Place.Name);
                    }
                }
            }
        }

        public FilteredFeedFormControl Control
        {
            get { return this.m_Feed; }
        }

        private void clearListBoxes()
        {
            this.m_Feed.ListBoxFriendsFeed.Items.Clear();
            this.m_Feed.ListBoxFriendsFeed.DisplayMember = "Name";            
            this.m_Feed.ListBoxPostsFeed.Items.Clear();
            this.m_Feed.ListBoxPostsFeed.DisplayMember = "Name";
            this.m_Feed.ListBoxBirthdaysFeed.Items.Clear();
            this.m_Feed.ListBoxBirthdaysFeed.DisplayMember = "Birthday";
            this.m_Feed.ListBoxEventsFeed.Items.Clear();
            this.m_Feed.ListBoxEventsFeed.DisplayMember = "Name";
            this.m_Feed.ListBoxPagesFeed.Items.Clear();
            this.m_Feed.ListBoxPagesFeed.DisplayMember = "Name";
            this.m_Feed.ListBoxCheckinsFeed.Items.Clear();
            this.m_Feed.ListBoxCheckinsFeed.DisplayMember = "Name";
        }
    }
}
