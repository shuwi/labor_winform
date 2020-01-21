using Flurl;
using Flurl.Http;
using LaborStackApp.Response;
using log4net;
using Newtonsoft.Json;
using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaborStackApp.Toolkits
{
    public class Common
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Common));
        /// <summary>
        /// 错误弹出提示
        /// </summary>
        /// <param name="content"></param>
        public static void ErrAlert(string content)
        {
            MessageBox.Show(content, "提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
        }
        /// <summary>
        /// 成功弹出提示
        /// </summary>
        /// <param name="content"></param>
        public static void SuccessAlert(string content)
        {
            MessageBox.Show(content, "提示",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
        }
        /// <summary>
        /// 从指定命名空间获取公共类名列表
        /// </summary>
        /// <param name="nameSpace">命名空间</param>
        /// <returns></returns>
        public static List<string> GetClasses(string nameSpace)
        {
            Assembly asm = Assembly.GetExecutingAssembly();
            List<string> classlist = new List<string>();

            foreach (Type type in asm.GetTypes())
                if (type.Namespace == nameSpace)
                    classlist.Add(type.FullName);

            return classlist;
        }

        /// <summary>
        /// 通过反射类名执行建表操作
        /// </summary>
        /// <param name="db">数据库连接</param>
        /// <param name="nameSpace">命名空间</param>
        public static void DataTableInitExecute(SQLiteConnection db, string nameSpace)
        {
            List<string> classList = GetClasses(nameSpace);
            foreach (string s in classList)
            {
                Type t = Type.GetType(s);
                if (null == t)
                    continue;
                db.CreateTable(t);
            }
        }
        /// <summary>
        /// POST请求工具
        /// </summary>
        /// <typeparam name="T">返回对象模型</typeparam>
        /// <param name="data">请求数据</param>
        /// <param name="baseURL">基地址</param>
        /// <param name="path">相对地址</param>
        /// <param name="res">返回对象</param>
        public static void PostRequest<T>(object data, string baseURL, string path, ref T res)
        {
            try
            {
                Task<T> result = baseURL
                .AppendPathSegment(path)
                .PostJsonAsync(data)
                .ReceiveJson<T>();
                res = result.Result;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("PostRequest Exception {0}", ex.Message);
            }
        }
        public static void GetRequest<T>(object data, string baseURL, string path, string token, string contentType, ref T res)
        {
            try
            {
                Task<T> result = baseURL
                .AppendPathSegment(path).SetQueryParams(data).GetJsonAsync<T>();
                res = result.Result;
            }
            catch (Exception ex)
            {
                log.ErrorFormat("GetRequest Exception {0}", ex.Message);
            }
        }
       
        /// <summary>
        /// 携带referer的统一POST请求
        /// </summary>
        /// <param name="data">请求数据</param>
        /// <param name="baseURL">基地址</param>
        /// <param name="path">相对地址，区分实际不同的请求</param>
        /// <param name="res">用对象封装返回数据</param>
        public static void PostRequest<T>(object data, string baseURL, string path, string token, string contentType, ref T res)
        {
            try
            {
                if (contentType.Equals("application/json"))
                {
                    Task<T> task = baseURL.
                        WithHeader("Content-Type", contentType)
                    .AppendPathSegment(path)
                    .WithOAuthBearerToken(token)
                    .PostJsonAsync(data).ReceiveJson<T>();
                    res = task.Result;
                }
                else
                {
                    Task<T> task = baseURL.
                        WithHeader("Content-Type", contentType)
                    .AppendPathSegment(path)
                    .WithOAuthBearerToken(token)
                    .PostUrlEncodedAsync(data).ReceiveJson<T>();
                    res = task.Result;
                }
            }
            catch (Exception ex)
            {
                res = default(T);
                log.Error(ex.Message);
            }
        }

        public static string ImageToBase64(Image image)
        {
            try
            {
                if (image == null) return string.Empty;
                using (Bitmap bitmap = new Bitmap(image))
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        bitmap.Save(stream, ImageFormat.Jpeg);
                        return Convert.ToBase64String(stream.GetBuffer());
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return string.Empty;
            }

        }

        /// <summary>
        /// MD5字符串加密
        /// </summary>
        /// <param name="txt"></param>
        /// <returns>加密后字符串</returns>
        public static string GenerateMD5(string txt)
        {
            using (MD5 mi = MD5.Create())
            {
                byte[] buffer = Encoding.Default.GetBytes(txt);
                //开始加密
                byte[] newBuffer = mi.ComputeHash(buffer);
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < newBuffer.Length; i++)
                {
                    sb.Append(newBuffer[i].ToString("X2"));
                }
                return sb.ToString().ToLower();
            }
        }

        public static void BorderDraw(object sender, PaintEventArgs e, Color BorderColor)
        {
            FlowLayoutPanel flowLayoutPanel = sender as FlowLayoutPanel;
            ControlPaint.DrawBorder(
                e.Graphics,
                flowLayoutPanel.ClientRectangle,
                BorderColor, 1, ButtonBorderStyle.Solid, //左边
　　　　　      BorderColor, 1, ButtonBorderStyle.Solid, //上边
　　　　　      BorderColor, 1, ButtonBorderStyle.Solid, //右边
　　　　　      BorderColor, 1, ButtonBorderStyle.Solid
           );//底边
        }

        public static Bitmap ZoomImage(Bitmap bitmap, int destHeight, int destWidth)
        {
            try
            {
                Image sourImage = bitmap;
                int width = 0, height = 0;
                //按比例缩放             
                int sourWidth = sourImage.Width;
                int sourHeight = sourImage.Height;
                if (sourHeight > destHeight || sourWidth > destWidth)
                {
                    if ((sourWidth * destHeight) > (sourHeight * destWidth))
                    {
                        width = destWidth;
                        height = (destWidth * sourHeight) / sourWidth;
                    }
                    else
                    {
                        height = destHeight;
                        width = (sourWidth * destHeight) / sourHeight;
                    }
                }
                else
                {
                    width = sourWidth;
                    height = sourHeight;
                }
                Bitmap destBitmap = new Bitmap(destWidth, destHeight);
                Graphics g = Graphics.FromImage(destBitmap);
                g.Clear(Color.Transparent);
                //设置画布的描绘质量           
                g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(sourImage, new Rectangle((destWidth - width) / 2, (destHeight - height) / 2, width, height), 0, 0, sourImage.Width, sourImage.Height, GraphicsUnit.Pixel);
                g.Dispose();
                //设置压缩质量       
                EncoderParameters encoderParams = new EncoderParameters();
                long[] quality = new long[1];
                quality[0] = 100;
                EncoderParameter encoderParam = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
                encoderParams.Param[0] = encoderParam;
                sourImage.Dispose();
                return destBitmap;
            }
            catch
            {
                return bitmap;
            }
        }
        /// <summary>
        /// 缩放矩形框
        /// </summary>
        /// <param name="sourWidth"></param>
        /// <param name="sourHeight"></param>
        /// <param name="destWidth"></param>
        /// <param name="destHeight"></param>
        public static void JustifyRectangle(int sourWidth, int sourHeight, ref int destWidth, ref int destHeight)
        {
            int width = 0, height = 0;
            //按比例缩放             
            if (sourHeight > destHeight || sourWidth > destWidth)
            {
                if ((sourWidth * destHeight) > (sourHeight * destWidth))
                {
                    width = destWidth;
                    height = (destWidth * sourHeight) / sourWidth;
                }
                else
                {
                    height = destHeight;
                    width = (sourWidth * destHeight) / sourHeight;
                }
            }
            else
            {
                width = sourWidth;
                height = sourHeight;
            }
            destWidth = width;
            destHeight = height;
        }

        public static Bitmap Base64ToImg(string strBase64)
        {
            try
            {
                byte[] bt = Convert.FromBase64String(strBase64);
                MemoryStream stream = new MemoryStream(bt);
                Bitmap bitmap = new Bitmap(stream);
                return bitmap;
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                return null;
            }
        }

        public static string TimeStampToDateTimeStr(long timeStamp)
        {
            DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
            DateTime dt = startTime.AddSeconds(timeStamp / 1000);
            return dt.ToString("yyyyMMdd");
        }

        public static string CuteTime(string datetime)
        {
            if (null == datetime)
                return "--";
            if (string.Empty.Equals(datetime))
                return "暂无";
            if (datetime.Split(' ').Length != 2)
                return "未知";
            return datetime.Split(' ')[0];
        }

        public static Nation GetNation(List<Nation> nationList, int nationId)
        {
            foreach (Nation nation in nationList)
            {
                if (nationId == nation.num)
                    return nation;
            }
            return null;
        }

        public static Nation GetNationNum(List<Nation> nationList, string nationName)
        {
            foreach (Nation nation in nationList)
            {
                if (nationName.Equals(nation.name))
                    return nation;
            }
            return null;
        }

        public static string GetGenderFromIDCardNumber(string idCardNumber)
        {
            if (idCardNumber.Length != 18)
                return "证件号错误";
            string sub = idCardNumber.Substring(idCardNumber.Length - 2, 1);
            if (int.TryParse(sub, out int num))
                return num % 2 == 0 ? "女" : "男";
            else
                return "无法解析";
        }

        public static string GetBirthdayFromIDCardNumber(string idCardNumber)
        {
            if (idCardNumber.Length != 18)
                return string.Empty;
            string sub = idCardNumber.Substring(6, 8);
            return sub.Substring(0, 4) + "-" + sub.Substring(4, 2) + "-" + sub.Substring(6, 2);
        }

    }
}
