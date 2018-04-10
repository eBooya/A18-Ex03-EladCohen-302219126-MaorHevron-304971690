using System;
using System.Windows.Forms;
using System.Net;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// plays the role of Singleton Pattern
    /// </summary>
    public class MatchingResultFormManager
    {
        private static MatchingResultFormManager s_Instance = null;
        private static object s_LockObj = new object();
        private User m_LoggedInUser;
        private FormMatchingResult m_MatchingResultForm = new FormMatchingResult();

        public User FriendUser { get; set; }

        private MatchingResultFormManager(User i_LoggedInUser)
        {
            m_LoggedInUser = i_LoggedInUser;
        }

        public static MatchingResultFormManager GetInstanse(User io_LoggedInUser)
        {
            if(s_Instance == null)
            {
                lock(s_LockObj)
                {
                    if(s_Instance == null)
                    {
                        s_Instance = new MatchingResultFormManager(io_LoggedInUser);
                    }
                }
            }

            return s_Instance;
        }

        public string getSummaryZodiacSignsMatching()
        {
            string StartsSubStringSummaryCode = getStartsSubStringSummaryCode();
            string SummaryZodiacSignsMatching;
            int EndIndexSummaryCode = StartsSubStringSummaryCode.IndexOf('<');
            SummaryZodiacSignsMatching = StartsSubStringSummaryCode.Substring(0, EndIndexSummaryCode);
            return SummaryZodiacSignsMatching;
        }

        private string getStartsSubStringSummaryCode()
        {
            string ZodiacCompatibilityWebUrl = getZodiacCompatibilityWebUrl();
            WebClient client = new WebClient();
            string HtmlCodeZodiacCompatibility = client.DownloadString(ZodiacCompatibilityWebUrl);
            string ToBeSearched = "Summary</h2>\n<div class=\"vidider\"></div>\n<p>";
            string StartsSubStringSummaryCode = HtmlCodeZodiacCompatibility.Substring(HtmlCodeZodiacCompatibility.IndexOf(ToBeSearched) + ToBeSearched.Length);
            return StartsSubStringSummaryCode;
        }

        private string getZodiacCompatibilityWebUrl()
        {
            string ZodiacCompatibilityWebUrl;
            string UserZodiacSign = m_LoggedInUser.getZodiacSign();
            string FriendZodiacSign = FriendUser.getZodiacSign();
            UserZodiacSign = UserZodiacSign.ToLower();
            FriendZodiacSign = FriendZodiacSign.ToLower();
            ZodiacCompatibilityWebUrl = string.Format("http://www.astrology-zodiac-signs.com/compatibility/{0}-{1}", UserZodiacSign, FriendZodiacSign);
            return ZodiacCompatibilityWebUrl;
        }

        private string getMatchingPercents()
        {
            string StartsSubStringSummaryCode = getStartsSubStringSummaryCode();
            string StartsSubStringMatchingPercents;
            string ToBeSearched = "skills-tittle percentual\">"; // looking for the string ToBeSearched in the html string for starting in the index of the percents matching
            StartsSubStringMatchingPercents = StartsSubStringSummaryCode.Substring(StartsSubStringSummaryCode.IndexOf(ToBeSearched) + ToBeSearched.Length);
            int EndIndexSummaryCode = StartsSubStringMatchingPercents.IndexOf('%');
            string MatchingPercents = StartsSubStringMatchingPercents.Substring(0, EndIndexSummaryCode + 1);
            return MatchingPercents;
        }

        public void DisplayMatchingResultForm()
        {
            try
            {
                string SummaryZodiacSignsMatching = getSummaryZodiacSignsMatching();
                string MatchingPercents = getMatchingPercents();
                m_MatchingResultForm.LoggedInUser = m_LoggedInUser;
                m_MatchingResultForm.UserFriend = FriendUser;
                m_MatchingResultForm.setMatchingResultToTextBox(SummaryZodiacSignsMatching, MatchingPercents);
                m_MatchingResultForm.setFriendInfo();
                m_MatchingResultForm.setLoggedInUserInfo();
                m_MatchingResultForm.SetScreenToCenter();
                m_MatchingResultForm.ShowDialog();
            }
            catch (Exception e)
            {
                MessageBox.Show(string.Format(
@"Error detected: {0}", e.Message));
            }
        }
    }
}
