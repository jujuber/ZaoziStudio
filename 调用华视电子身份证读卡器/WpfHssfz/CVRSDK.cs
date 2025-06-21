using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.InteropServices;
using WpfHssfz;//这是用到DllImport时候要引入的包 

namespace YLW.UHIS.Utility
{
    /// <summary>
    /// 身份证阅读类
    /// </summary>
    public class CVRSDK
    {
        static int m_Port = 0;
        static int m_Baudrate = 115200;
        static bool m_ComOpen = false;


        [DllImport("Termb.dll", EntryPoint = "CVR_SetBaudRate", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int CVR_SetComBaudrate(int nBaudRate);//声明外部的标准动态库, 跟Win32API是一样的,设置波特率

        [DllImport("Termb.dll", EntryPoint = "CVR_InitComm", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int CVR_InitComm(int Port);//声明外部的标准动态库, 跟Win32API是一样的


        [DllImport("Termb.dll", EntryPoint = "CVR_Authenticate", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int CVR_Authenticate();


        [DllImport("Termb.dll", EntryPoint = "CVR_Read_Content", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int CVR_Read_Content(int Active);


        [DllImport("Termb.dll", EntryPoint = "CVR_Read_FPContent", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int CVR_Read_FPContent();

        [DllImport("Termb.dll", EntryPoint = "CVR_FindCard", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int CVR_FindCard();

        [DllImport("Termb.dll", EntryPoint = "CVR_SelectCard", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int CVR_SelectCard();


        [DllImport("Termb.dll", EntryPoint = "CVR_CloseComm", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int CVR_CloseComm();

        [DllImport("Termb.dll", EntryPoint = "GetCertType", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int GetCertType(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetPeopleName", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int GetPeopleName(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetPeopleChineseName", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int GetPeopleChineseName(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetPeopleNation", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int GetPeopleNation(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetNationCode", CharSet = CharSet.Ansi, SetLastError = false)]
        public static extern int GetNationCode(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetPeopleBirthday", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPeopleBirthday(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetPeopleAddress", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPeopleAddress(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetPeopleIDCode", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPeopleIDCode(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetDepartment", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetDepartment(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetStartDate", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetStartDate(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetEndDate", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetEndDate(ref byte strTmp, ref int strLen);


        [DllImport("Termb.dll", EntryPoint = "GetPeopleSex", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetPeopleSex(ref byte strTmp, ref int strLen);


        //[DllImport("Termb.dll", EntryPoint = "CVR_GetIDCardUID", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        //public static extern int GetIDCardUID(ref byte strTmp, int strLen);

        [DllImport("Termb.dll", EntryPoint = "GetBMPData", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetBMPData(ref byte btBmp, ref int nLen);

        [DllImport("Termb.dll", EntryPoint = "GetJpgData", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int GetJpgData(ref byte btBmp, ref int nLen);

        [DllImport("Termb.dll", EntryPoint = "M1_MF_HL_Request", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int M1_MF_HL_Request(byte nMode, ref byte pSNR, ref byte pTagType);

        [DllImport("Termb.dll", EntryPoint = "M1_MF_HL_Read", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int M1_MF_HL_Read(byte nMode, uint nSNR, byte nBlock, ref byte nKey, ref byte pReadBuff, uint nBuff);

        [DllImport("Termb.dll", EntryPoint = "M1_MF_HL_Write", CharSet = CharSet.Ansi, SetLastError = false, CallingConvention = CallingConvention.StdCall)]
        public static extern int M1_MF_HL_Write(byte nMode, uint nSNR, byte nBlock, ref byte nKey, ref byte pWriteBuff, uint nBuff);



        public static IdentityCardInfo GetData()
        {
            IdentityCardInfo identityCardInfo = new IdentityCardInfo();

            try
            {

                if (m_ComOpen)
                {
                    //CVRSDK.CVR_CloseComm();
                    //m_ComOpen = false;

                }
                else
                {
                    CVRSDK.CVR_SetComBaudrate(m_Baudrate);// 设置波特率
                    if (0 == m_Port)    //usb
                    {
                        for (int i = 1001; i <= 1016; i++)
                        {
                            if (1 == CVRSDK.CVR_InitComm(i))
                            {
                                m_ComOpen = true;
                                m_Port = i;
                                break;
                            }
                        }
                    }
                    else if (CVRSDK.CVR_InitComm(m_Port) == 1)  //UART
                    {
                        m_ComOpen = true;
                    }

                    if (!m_ComOpen)
                    {

                        CVRSDK.CVR_CloseComm();

                    }
                    else
                    {
                    }
                }

                int authenticate = CVRSDK.CVR_Authenticate();

                if (authenticate == 1)
                {
                    int readContent = CVRSDK.CVR_Read_Content(4);
                    if (readContent == 1)
                    {


                    }
                    else
                    {
                        throw new Exception("读卡操作失败");
                    }
                }
                else
                {
                    throw new Exception("未放卡或卡片放置不正确");

                }

                int length;

                byte[] name = new byte[128];
                length = 128;
                CVRSDK.GetPeopleName(ref name[0], ref length);

                byte[] cnName = new byte[128];
                length = 128;
                CVRSDK.GetPeopleChineseName(ref cnName[0], ref length);

                byte[] number = new byte[128];
                length = 128;
                CVRSDK.GetPeopleIDCode(ref number[0], ref length);

                byte[] peopleNation = new byte[128];
                length = 128;
                CVRSDK.GetPeopleNation(ref peopleNation[0], ref length);

                byte[] peopleNationCode = new byte[128];
                    length = 128;
                CVRSDK.GetNationCode(ref peopleNationCode[0], ref length);

                byte[] validtermOfStart = new byte[128];
                length = 128;
                CVRSDK.GetStartDate(ref validtermOfStart[0], ref length);

                byte[] birthday = new byte[128];
                length = 128;
                CVRSDK.GetPeopleBirthday(ref birthday[0], ref length);

                byte[] address = new byte[128];
                length = 128;
                CVRSDK.GetPeopleAddress(ref address[0], ref length);

                byte[] validtermOfEnd = new byte[128];
                length = 128;
                CVRSDK.GetEndDate(ref validtermOfEnd[0], ref length);

                byte[] signdate = new byte[128];
                length = 128;
                CVRSDK.GetDepartment(ref signdate[0], ref length);

                byte[] sex = new byte[128];
                length = 128;
                CVRSDK.GetPeopleSex(ref sex[0], ref length);

                byte[] Uid = new byte[128];
                length = 128;

                //CVRSDK.GetIDCardUID(ref Uid[0], 128);

                bool bCivic = true;
                byte[] certType = new byte[32];
                length = 32;
                CVRSDK.GetCertType(ref certType[0], ref length);

                string strType = System.Text.Encoding.ASCII.GetString(certType);
                int nStart = strType.IndexOf("I");
                if (nStart != -1) bCivic = false;



                identityCardInfo.Name = System.Text.Encoding.GetEncoding("GB2312").GetString(name);

                identityCardInfo.Gender = System.Text.Encoding.GetEncoding("GB2312").GetString(sex).Replace("\0", "").Trim();

                identityCardInfo.Folk = System.Text.Encoding.GetEncoding("GB2312").GetString(peopleNation).Replace("\0", "").Trim();

                identityCardInfo.BirthDay = System.Text.Encoding.GetEncoding("GB2312").GetString(birthday).Replace("\0", "").Trim();

                identityCardInfo.Code = System.Text.Encoding.GetEncoding("GB2312").GetString(number).Replace("\0", "").Trim();

                identityCardInfo.Address = System.Text.Encoding.GetEncoding("GB2312").GetString(address).Replace("\0", "").Trim();

                identityCardInfo.Agency = System.Text.Encoding.GetEncoding("GB2312").GetString(signdate).Replace("\0", "").Trim();

                identityCardInfo.ExpireStart = System.Text.Encoding.GetEncoding("GB2312").GetString(validtermOfStart).Replace("\0", "").Trim();

                identityCardInfo.ExpireEnd = System.Text.Encoding.GetEncoding("GB2312").GetString(validtermOfEnd).Replace("\0", "").Trim();

                identityCardInfo.resultInfo = new ResultInfo() { Code = "1", Msg = "成功" };


            }
            catch (Exception ex)
            {
                identityCardInfo.resultInfo = new ResultInfo() { Code = "0", Msg = ex.Message };
            }

            return identityCardInfo;
        }

    }

}
