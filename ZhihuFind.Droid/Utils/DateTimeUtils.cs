using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace ZhihuFind.Droid.Utils
{
    public class DateTimeUtils
    {
        public static string CommonTime(DateTime dt)
        {
            TimeSpan span = DateTime.Now.Subtract(dt);
            if (span.Days > 0)
            {
                var month = (DateTime.Now.Year - dt.Year) * 12 + DateTime.Now.Month - dt.Month;

                if (month >= 12)
                {
                    return string.Format("{0}��ǰ", (month / 12).ToString());
                }
                else if (month > 0)
                {
                    return string.Format("{0}��ǰ", month.ToString());
                }
                else
                {
                    return string.Format("{0}��ǰ", span.Days.ToString());
                }
            }
            else
            {
                if (span.Hours > 0)
                {
                    return string.Format("{0}Сʱǰ", span.Hours.ToString());
                }
                else
                {
                    if (span.Minutes > 0)
                    {
                        return string.Format("{0}����ǰ", span.Minutes.ToString());
                    }
                    else
                    {
                        if (span.Seconds > 5)
                        {
                            return string.Format("{0}��ǰ", span.Seconds.ToString());
                        }
                        else
                        {
                            return "�ո�";
                        }
                    }
                }
            }

        }
    }
}