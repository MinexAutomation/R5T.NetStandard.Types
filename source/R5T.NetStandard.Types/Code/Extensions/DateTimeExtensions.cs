﻿using System;


namespace R5T.NetStandard
{
    public static class DateTimeExtensions
    {
    }
}


namespace R5T.NetStandard.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToYYYYMMDD(this DateTime dateTime)
        {
            var output = $"{dateTime:yyyyMMdd}";
            return output;
        }

        public static string ToHHMMSS(this DateTime dateTime)
        {
            string output = $"{dateTime:HHmmss}";
            return output;
        }

        public static string ToYYYYMMDD_HHMMSS(this DateTime dateTime)
        {
            string yyyymmdd = dateTime.ToYYYYMMDD();
            string hhmmss = dateTime.ToHHMMSS();

            string output = $"{yyyymmdd}-{hhmmss}";
            return output;
        }

        public static string ToHHMMSS_FFF(this DateTime dateTime)
        {
            var output = $"{dateTime:HHmmss.fff}";
            return output;
        }

        public static string ToYYYYMMDD_HHMMSS_FFF(this DateTime dateTime)
        {
            var yyyymmdd = dateTime.ToYYYYMMDD();
            var hhmmssfff = dateTime.ToHHMMSS_FFF();

            var output = $"{yyyymmdd}-{hhmmssfff}";
            return output;
        }

        public static string ToMostLegibleUS(this DateTime dateTime)
        {
            var output = $"{dateTime:MM/dd/yyyy HH:mm:ss tt}";
            return output;
        }
    }
}
