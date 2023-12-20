using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace SportsShop.Domain.Convertors
{
    public static class DateConvertor
    {
        public static string ToShamsi(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" +
                   pc.GetDayOfMonth(value).ToString("00");
        }
        public static string ToShamsiTime(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" +
                   pc.GetDayOfMonth(value).ToString("00") + " " + value.ToString("HH:mm:ss");
        }
        public static string ToShamsiTimeName(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            var res= pc.GetYear(value) + "/" + pc.GetMonth(value).ToString("00") + "/" +
                   pc.GetDayOfMonth(value).ToString("00") + "_" + value.ToString("HH:mm:ss");

            var replace = res.Replace("/","-").Replace(":","-");

            return replace;
        }

        public static DateTime ToMiladi(this DateTime dateTime)
        {
            return new DateTime(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0, new System.Globalization.PersianCalendar());
        }

        public static string GetDay(this DateTime date)
        {
            DayOfWeek dayOfWeek = date.DayOfWeek;
            switch (dayOfWeek)
            {
                case DayOfWeek.Friday:
                    {
                        return "جمعه";
                    }
                case DayOfWeek.Monday:
                    {
                        return "دوشنبه";
                    }
                case DayOfWeek.Saturday:
                    {
                        return "شنبه";
                    }
                case DayOfWeek.Sunday:
                    {
                        return "یکشنبه";
                    }
                case DayOfWeek.Thursday:
                    {
                        return "پنچشنبه";
                    }
                case DayOfWeek.Wednesday:
                    {
                        return "چهارشنبه";
                    }
                case DayOfWeek.Tuesday:
                    {
                        return "سه شنبه";
                    }
                default:
                    {
                        return "هیچ";
                    }
            }

        }
        public static int GetDayPersian(this DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetDayOfMonth(value);
        }
        public static int GetMonth(this DateTime date)
        {
            string res = date.ToShamsi();
            int month = int.Parse(res.Split("/")[1]);
            return month;
        }

        public static int GetSeason(this DateTime date)
        {

            int month = GetMonth(date);

            if (month == 1 || month == 2 || month == 3)
                return 1;
            if (month == 4 || month == 5 || month == 6)
                return 2;
            if (month == 7 || month == 8 || month == 9)
                return 3;
            if (month == 10 || month == 11 || month == 12)
                return 4;

            return 0;
        }

        public static (int seasonId, string seasonName) GetSeason(int month)
        {
            int seasonId = 0;
            string seasonName = "";
            if (month == 1 || month == 2 || month == 3)
            {
                seasonId = 1;
                seasonName = "بهار";
            }

            if (month == 4 || month == 5 || month == 6)
            {
                seasonId = 2;
                seasonName = "تابستان";
            }

            if (month == 7 || month == 8 || month == 9)
            {
                seasonId = 3;
                seasonName = "پاییز";
            }

            if (month == 10 || month == 11 || month == 12)
            {
                seasonId = 4;
                seasonName = "زمستان";
            }
            return (seasonId, seasonName);
        }


        public static int GetMonthOfSeason(this DateTime date)
        {
            string res = date.ToShamsi();
            int month = int.Parse(res.Split("/")[1]);

            if (month == 1 || month == 4 || month == 7 || month == 10)
                return 1;
            if (month == 2 || month == 5 || month == 8 || month == 11)
                return 2;
            if (month == 3 || month == 6 || month == 9 || month == 12)
                return 3;


            return 0;
        }



        public static DateTime SubtractDateOfMonth(DateTime dateTime, int month)
        {

            var year = dateTime.GetYear();
            var months = dateTime.GetMonth().ToString();

            var date = $"{year}/{months}/01";

            dateTime = date.ToDateTime();

            var persianCalendar = new System.Globalization.PersianCalendar();
            var today = dateTime;
            dateTime = persianCalendar.AddMonths(today, month);

             year = dateTime.GetYear();
             months = dateTime.GetMonth().ToString();

             date = $"{year}/{months}/01";

            return date.ToDateTime();
        }

        public static string GetYear(this DateTime date)
        {
            var res = date.ToShamsi();
            var year = res.Split("/")[0];
            return year;
        }

        public static DateTime ToDateTime(this string dateTime)
        {
            PersianCalendar p = new PersianCalendar();
            string[] parts = dateTime.Split(new[] { '/', '-' });
            return p.ToDateTime(Convert.ToInt32(parts[0]), Convert.ToInt32(parts[1]), Convert.ToInt32(parts[2]), 0, 0, 0, 0);
        }


        public static int GetPeriodicChapter(this DateTime startDate, DateTime endDate)
        {
            startDate = startDate.ConvertDateTime();
            endDate = endDate.ConvertDateTime();

            double dispute = (endDate - startDate).TotalDays;
            var season = dispute / 90;
            var result = Math.Round(season, MidpointRounding.ToPositiveInfinity);

            return Convert.ToInt32(result);
        }

        private static DateTime ConvertDateTime(this DateTime dateTime)
        {
            string year = dateTime.GetYear();
            int month = dateTime.GetMonth();

            string m = "";

            if (month == 1 || month == 2 || month == 3)
                m = "01";

            else if (month == 4 || month == 5 || month == 6)
                m = "04";

            else if (month == 7 || month == 8 || month == 9)
                m = "07";

            else if (month == 10 || month == 11 || month == 12)
                m = "10";

            var result = $"{year}/{m}/01";

            return result.ToDateTime();
        }

        public static int CalculateMonthTwoDates(this DateTime date1, DateTime date2)
        {
            int response = Math.Abs(((date1.Year - date2.Year) * 12) + date1.Month - date2.Month);


            return response + 1;
        }

        public static string GetMonthName(int month)
        {
            switch (month)
            {
                case 1:
                    return "فروردین";
                case 2:
                    return "اردیبهشت";
                case 3:
                    return "خرداد";
                case 4:
                    return "تیر";
                case 5:
                    return "مرداد";
                case 6:
                    return "شهریور";
                case 7:
                    return "مهر";
                case 8:
                    return "آبان";
                case 9:
                    return "آذر";
                case 10:
                    return "دی";
                case 11:
                    return "بهمن";
                case 12:
                    return "اسفند";
                default:
                    return "هیچ";

            }
        }


        public static DateTime GetDateActions(string year,int monthId)
        {
            string result = $"{year}/{monthId}/01";
            return result.ToDateTime();
        }
    }
}
