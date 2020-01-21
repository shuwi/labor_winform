using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Text;

namespace LaborStackApp.SDK
{
    public class ReaderLib
    {
        private static int intPort = 0;
        private static int iRet = 0;
        public static string ReadInfo()
        {
            try
            {
                string str = string.Empty;
                str = str.PadLeft(100);
                StringBuilder str1 = new StringBuilder(str);

                if (intPort == 0)
                {
                    for (int i = 1; i < 16; i++)
                    {
                        iRet = LibClass.InitComm(i);
                        if (iRet == 1)
                        {
                            intPort = i;
                            break;
                        }
                    }
                }
                else
                {
                    iRet = LibClass.InitComm(intPort);
                }

                if (intPort == 0)
                {
                    for (int j = 1001; j < 1016; j++)
                    {
                        iRet = LibClass.InitComm(j);
                        if (iRet == 1)
                        {
                            intPort = j;
                            break;
                        }
                    }
                }

                if (intPort == 0)
                {

                    return JsonConvert.SerializeObject(JObject.FromObject(new
                    {
                        code = 0,
                        des = Properties.Resources.CARD_READ_NOTFOUND
                    }));
                }

                iRet = LibClass.Authenticate();

                iRet = LibClass.Read_Content(1);

                if (iRet != 1)
                {
                    return JsonConvert.SerializeObject(JObject.FromObject(new
                    {
                        code = -1,
                        des = Properties.Resources.CARD_READ_FAILURE
                    }));
                }


                iRet = LibClass.GetPeopleName(str1, 100);
                string name = str1.ToString().Trim();

                str1.Length = 0;
                str1.Append(str);
                iRet = LibClass.GetPeopleAddress(str1, 100);
                string address = str1.ToString().Trim();

                str1.Length = 0;
                str1.Append(str);
                iRet = LibClass.GetPeopleIDCode(str1, 100);
                string idcode = str1.ToString().Trim();

                str1.Length = 0;
                str1.Append(str);
                iRet = LibClass.GetPeopleBirthday(str1, 100);
                string birthday = str1.ToString().Trim();

                str1.Length = 0;
                str1.Append(str);
                iRet = LibClass.GetPeopleNation(str1, 100);
                string nation = str1.ToString().Trim();

                str1.Length = 0;
                str1.Append(str);
                iRet = LibClass.GetPeopleSex(str1, 100);
                string gender = str1.ToString().Trim();

                str1.Length = 0;
                str1.Append(str);
                iRet = LibClass.GetDepartment(str1, 100);
                string department = str1.ToString().Trim();

                str1.Length = 0;
                str1.Append(str);
                iRet = LibClass.GetStartDate(str1, 100);
                string startdate = str1.ToString().Trim();

                str1.Length = 0;
                str1.Append(str);
                iRet = LibClass.GetEndDate(str1, 100);
                string enddate = str1.ToString().Trim();

                byte[] sber = new byte[38862];
                LibClass.GetPhotoBMP(sber, 38862);
                LibClass.CloseComm();

                return JsonConvert.SerializeObject(JObject.FromObject(new
                {
                    code = 1,
                    des = Properties.Resources.CARD_READ_SUCCEED,
                    info = new UserInfo
                    {
                        name = name,
                        address = address,
                        idcode = idcode,
                        birthday = birthday,
                        nation = nation,
                        gender = gender,
                        department = department,
                        startdate = startdate,
                        enddate = enddate,
                        photo = Convert.ToBase64String(sber)
                    }
                }), Formatting.Indented);
            }
            catch (Exception ex)
            {
                return JsonConvert.SerializeObject(JObject.FromObject(new
                {
                    code = -2,
                    des = Properties.Resources.CARD_READ_EXCEPTION + ex.Message
                }));
            }
        }
    }
}
