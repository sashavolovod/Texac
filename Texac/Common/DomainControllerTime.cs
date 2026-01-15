using System;
using System.Runtime.InteropServices;

namespace Texac.Common
{
    public class DomainControllerTime
    {
        [DllImport("netapi32.dll", CharSet = CharSet.Auto)]
        static extern int NetRemoteTOD(string server, out IntPtr bufptr);

        [DllImport("netapi32.dll")]
        static extern int NetApiBufferFree(IntPtr Buffer);

        [StructLayout(LayoutKind.Sequential)]
        public struct TIME_OF_DAY_INFO
        {
            public int tod_elapsedt;
            public int tod_msecs;
            public int tod_hours;
            public int tod_mins;
            public int tod_secs;
            public int tod_hunds;
            public int tod_timezone;
            public int tod_tinterval;
            public int tod_day;
            public int tod_month;
            public int tod_year;
            public int tod_weekday;
        }

        public static DateTime GetDomainControllerTime(string domainController)
        {
            IntPtr bufPtr;
            int result = NetRemoteTOD(domainController, out bufPtr);

            if (result == 0)
            {
                try
                {
                    TIME_OF_DAY_INFO todInfo = (TIME_OF_DAY_INFO)Marshal.PtrToStructure(bufPtr, typeof(TIME_OF_DAY_INFO));

                    DateTime time = new DateTime(
                        todInfo.tod_year,
                        todInfo.tod_month,
                        todInfo.tod_day,
                        todInfo.tod_hours,
                        todInfo.tod_mins,
                        todInfo.tod_secs,
                        todInfo.tod_hunds * 10);

                    return time;
                }
                finally
                {
                    NetApiBufferFree(bufPtr);
                }
            }
            else
            {
                throw new Exception($"Ошибка при получении времени: {result}");
            }
        }
    }
}
