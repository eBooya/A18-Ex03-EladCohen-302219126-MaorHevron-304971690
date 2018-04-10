using System;
using System.Globalization;
using FacebookWrapper.ObjectModel;

namespace A18_Ex03_Elad_302219126_Maor_304971690
{
    /// <summary>
    /// extension method for User
    /// </summary>
    public static class ZodiacSign
    {
        public static string getZodiacSign(this User i_FacebookUser)
        {
            if (i_FacebookUser != null)
            {
                DateTime UserBirthday = getUserBirthdayAsDateTimeType(i_FacebookUser);

                switch (UserBirthday.Month)
                {
                    case 1:
                        if (UserBirthday.Day <= 20)
                        {
                            return eZodiacSigns.Capricorn.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Aquarius.ToString();
                        }

                    case 2:
                        if (UserBirthday.Day <= 19)
                        {
                            return eZodiacSigns.Aquarius.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Pisces.ToString();
                        }

                    case 3:
                        if (UserBirthday.Day <= 20)
                        {
                            return eZodiacSigns.Pisces.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Aries.ToString();
                        }

                    case 4:
                        if (UserBirthday.Day <= 20)
                        {
                            return eZodiacSigns.Aries.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Taurus.ToString();
                        }

                    case 5:
                        if (UserBirthday.Day <= 21)
                        {
                            return eZodiacSigns.Taurus.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Gemini.ToString();
                        }

                    case 6:
                        if (UserBirthday.Day <= 22)
                        {
                            return eZodiacSigns.Gemini.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Cancer.ToString();
                        }

                    case 7:
                        if (UserBirthday.Day <= 22)
                        {
                            return eZodiacSigns.Cancer.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Leo.ToString();
                        }

                    case 8:
                        if (UserBirthday.Day <= 23)
                        {
                            return eZodiacSigns.Leo.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Virgo.ToString();
                        }

                    case 9:
                        if (UserBirthday.Day <= 23)
                        {
                            return eZodiacSigns.Virgo.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Libra.ToString();
                        }

                    case 10:
                        if (UserBirthday.Day <= 23)
                        {
                            return eZodiacSigns.Libra.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Scorpio.ToString();
                        }

                    case 11:
                        if (UserBirthday.Day <= 22)
                        {
                            return eZodiacSigns.Scorpio.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Sagittarius.ToString();
                        }

                    case 12:
                        if (UserBirthday.Day <= 21)
                        {
                            return eZodiacSigns.Sagittarius.ToString();
                        }
                        else
                        {
                            return eZodiacSigns.Capricorn.ToString();
                        }

                    default: return "No Zodiac sign exists";
                }
            }

            return "Not available Scenario";
        }

        public static DateTime getUserBirthdayAsDateTimeType(User i_FacebookUser)
        {
            DateTime UserBirthday;
            bool isMmDdYyyy = DateTime.TryParse(i_FacebookUser.Birthday, out UserBirthday);
            if (isMmDdYyyy == false)
            {
                UserBirthday = DateTime.ParseExact(i_FacebookUser.Birthday, "MM/dd", CultureInfo.InvariantCulture);
            }

            return UserBirthday;
        }

        public enum eZodiacSigns
        {
            Aries = 0,
            Taurus,
            Gemini,
            Cancer,
            Leo,
            Virgo,
            Libra,
            Scorpio,
            Sagittarius,
            Capricorn,
            Aquarius,
            Pisces
        }
    }
}
