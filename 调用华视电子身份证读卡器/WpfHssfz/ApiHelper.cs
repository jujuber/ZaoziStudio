using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfHssfz
{
    public class ApiHelper
    {
        // 引入动态库
        [DllImport("termb.dll", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "CVR_InitComm", SetLastError = true)]
        public static extern int CVR_InitComm(Int32 Port);

        [DllImport("termb.dll", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "CVR_CloseComm", SetLastError = true)]
        public static extern int CVR_CloseComm();

        [DllImport("termb.dll", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "CVR_Authenticate", SetLastError = true)]
        public static extern int CVR_Authenticate();

        [DllImport("termb.dll", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, EntryPoint = "CVR_Read_Content", SetLastError = true)]
        public static extern int CVR_Read_Content(Int32 active);
        /// <summary>
        /// 获取姓名
        /// </summary>
        /// <param name="strTmp"></param>
        /// <param name="strLen"></param>
        /// <returns></returns>

        [DllImport("termb.dll", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "GetPeopleName", SetLastError = true)]
        public static extern int GetPeopleName(StringBuilder strTmp, ref int strLen);
        /// <summary>
        /// 获取性别
        /// </summary>
        /// <param name="strTmp"></param>
        /// <param name="strLen"></param>
        /// <returns></returns>

        [DllImport("termb.dll", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "GetPeopleSex", SetLastError = true)]
        public static extern int GetPeopleSex(StringBuilder strTmp, ref int strLen);
        /// <summary>
        /// 获取民族
        /// </summary>
        /// <param name="strTmp"></param>
        /// <param name="strLen"></param>
        /// <returns></returns>

        [DllImport("termb.dll", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "GetPeopleNation", SetLastError = true)]
        public static extern int GetPeopleNation(StringBuilder strTmp, ref int strLen);
        /// <summary>
        /// 获取出生日期
        /// </summary>
        /// <param name="strTmp"></param>
        /// <param name="strLen"></param>
        /// <returns></returns>

        [DllImport("termb.dll", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "GetPeopleBirthday", SetLastError = true)]
        public static extern int GetPeopleBirthday(StringBuilder strTmp, ref int strLen);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="strTmp"></param>
        /// <param name="strLen"></param>
        /// <returns></returns>

        [DllImport("termb.dll", BestFitMapping = true, CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Ansi, EntryPoint = "GetPeopleIDCode", SetLastError = true)]
        public static extern int GetPeopleIDCode(StringBuilder strTmp, ref int strLen);

    }
}
