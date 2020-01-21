using System.Runtime.InteropServices;
using System.Text;

namespace LaborStackApp.SDK
{
    public class LibClass
    {
        #region 二代证阅读器接口
        /// <summary>
        /// 二代证阅读器接口
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32", EntryPoint = "GetModuleFileNameA")]
        public static extern int GetModuleFileName(int hModule, string lpFileName, int nSize);

        //初始化设备(串口:1-16,USB:1001-1016)
        [DllImport("termb.dll")]
        public static extern int InitComm(int X);
        //读卡完毕后，关闭设备
        [DllImport("termb.dll")]
        public static extern int CloseComm();
        //证卡验证，返回值不需要判断
        [DllImport("termb.dll")]
        public static extern int Authenticate();
        //读基本信息,iActive=1;读卡成功后照片信息存放在zp.bmp文件中;读追加地址,iActive=3;
        [DllImport("termb.dll")]
        public static extern int Read_Content(int Active);

        //读卡成功后调用以下方法获取相应的身份证信息：
        //		const	int ERR_SUCCESS			= 1;//成功
        //		const	int ERR_FAIL		    	= 0;//失败
        //		const	int ERR_SAVESERIALNO		= -1;//存序列号失败 未授权机具
        //		const	int ERR_CANCELSERIALNO		= -1;//序列号取消  未授权机具
        //		const	int ERR_OPENECOMM		= -2;//打开串口
        //		const	int ERR_CLOSECOMM		= -3;//关闭串口
        //		const	int ERR_SAMSTATUS		= -4;//取sam状态失败
        //		const	int ERR_SAMID		    	= -5;//取samID失败
        //		const	int ERR_FINDCARD		= -6;//找卡错误
        //		const	int ERR_SELECTCARD		= -7;//选卡错误
        //		const	int ERR_BASEINFO		= -8;//读取基本信息错误
        //		const	int ERR_APPINFO			= -9;//读取附加信息错误
        //		const	int ERR_MNGINFO			= -10;//读取MNG信息错误
        //姓名
        [DllImport("termb.dll")]
        public static extern int GetPeopleName(StringBuilder lpBuffer, uint strLen);
        //地址
        [DllImport("termb.dll")]
        public static extern int GetPeopleAddress(StringBuilder lpBuffer, uint strLen);
        //身份证号码
        [DllImport("termb.dll")]
        public static extern int GetPeopleIDCode(StringBuilder lpBuffer, uint strLen);
        //出生日期
        [DllImport("termb.dll")]
        public static extern int GetPeopleBirthday(StringBuilder lpBuffer, uint strLen);
        //民族
        [DllImport("termb.dll")]
        public static extern int GetPeopleNation(StringBuilder lpBuffer, uint strLen);
        //性别
        [DllImport("termb.dll")]
        public static extern int GetPeopleSex(StringBuilder lpBuffer, uint strLen);
        //发证机关
        [DllImport("termb.dll")]
        public static extern int GetDepartment(StringBuilder lpBuffer, uint strLen);
        //证件开始日期
        [DllImport("termb.dll")]
        public static extern int GetStartDate(StringBuilder lpBuffer, uint strLen);
        //证件结束日期
        [DllImport("termb.dll")]
        public static extern int GetEndDate(StringBuilder lpBuffer, uint strLen);
        //照片
        [DllImport("termb.dll")]
        public static extern int GetPhotoBMP(byte[] lpBuffer, uint strLen);
        //追加地址
        [DllImport("termb.dll")]
        public static extern int GetAppAddress(uint index, StringBuilder lpBuffer, uint strLen);
        #endregion
    }
}
