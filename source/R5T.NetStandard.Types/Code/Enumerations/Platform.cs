﻿using System;


namespace R5T.NetStandard
{
    public enum Platform
    {
        Windows,
        NonWindows,
    }


    public static class PlatformExtensions
    {
        public const string WindowsName = @"Windows";
        public const string NonWindowsName = @"NonWindows";


        public static string ToStringStandard(this Platform platform)
        {
            switch (platform)
            {
                case Platform.NonWindows:
                    return PlatformExtensions.NonWindowsName;

                case Platform.Windows:
                    return PlatformExtensions.WindowsName;

                default:
                    throw new Exception(EnumHelper.GetUnexpectedEnumerationValueMessage(platform));
            }
        }
    }
}
