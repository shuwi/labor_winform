using AForge.Video.DirectShow;
using LaborStackApp.Model;
using LaborStackApp.Request;
using LaborStackApp.Response;
using LaborStackApp.SDK;
using LaborStackApp.Service.net;
using LaborStackApp.Toolkits;
using log4net;
using Newtonsoft.Json;
using SQLite;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LaborStackApp.Modal
{
    public partial class ManagerInfoForm : Form
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ManagerInfoForm));
        //默认的摄像头实时显示区域大小及截图区域大小
        private static readonly int FRAME_HEIGHT = 101;
        private static readonly int FRAME_WIDTH = 134;

        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoDevice;
        private VideoCapabilities[] videoCapabilities;

        private SQLiteConnection db;
        private ManagerListData manager;
        private ProjectInfo workerProjectInfo;
        private LoginUser loginUser;
        private List<Nation> nations;
        //截图base64数据
        private string ImageBase64 = string.Empty;

        public ManagerInfoForm(SQLiteConnection db, ManagerListData manager, ProjectInfo workerProjectInfo, LoginUser loginUser, List<Nation> nations)
        {
            InitializeComponent();
            this.db = db;
            this.manager = manager;
            this.workerProjectInfo = workerProjectInfo;
            this.loginUser = loginUser;
            this.nations = nations;
        }

        private void ManagerInfoForm_Load(object sender, System.EventArgs e)
        {
            FormClosing += ManagerInfoForm_FormClosing;
            CameraInit();
            FormInfoLoad();
        }
        /// <summary>
        /// 控件值初始化
        /// </summary>
        private void FormInfoLoad()
        {
            project_label.Text = workerProjectInfo.projectName;
            if (null == manager)
            {
                Text = "管理人员信息新增";
                return;
            }
            Text = "管理人员信息修改";
            if (!string.Empty.Equals(manager.ocvFace))
            {
                int h = FRAME_HEIGHT;
                int w = FRAME_WIDTH;
                Bitmap bitmap = Common.Base64ToImg(manager.ocvFace);
                Common.JustifyRectangle(bitmap.Width, bitmap.Height, ref w, ref h);
                picbPreview.Image = Common.ZoomImage(bitmap, h, w);
                picbPreview.Height = h;
                picbPreview.Width = w;
            }
            if (!string.Empty.Equals(manager.idCardPhoto))
                idcardNumber_pictureBox.BackgroundImage = Common.Base64ToImg(manager.idCardPhoto);
            idCardNumber_textBox.Text = manager.idCardNumber;
            address_textBox.Text = manager.address;
            workerName_textBox.Text = manager.workerName;
            nationName_textBox.Text = Common.GetNation(nations, int.Parse(manager.nation)).name;
            is_sue_textBox.Text = manager.is_sue;
            startTime_textBox.Text = Common.CuteTime(manager.start_time);
            endTime_textBox.Text = Common.CuteTime(manager.end_time);
        }

        private void ManagerInfoForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (vispShoot.VideoSource == null)
                return;
            vispShoot.SignalToStop();
            vispShoot.WaitForStop();
            vispShoot.VideoSource = null;
        }

        /// <summary>
        /// 打开摄像头
        /// </summary>
        private void CameraInit()
        {
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                Common.ErrAlert("未找到可用摄像头设备！");
                return;
            }
            videoDevice = new VideoCaptureDevice(videoDevices[0].MonikerString);
            if (videoDevice == null)
                return;
            videoCapabilities = videoDevice.VideoCapabilities;
            if (videoCapabilities == null)
                return;
            if (videoCapabilities.Length == 0)
                return;
            videoDevice.VideoResolution = videoCapabilities[0];
            int height = FRAME_HEIGHT;
            int width = FRAME_WIDTH;
            Common.JustifyRectangle(videoDevice.VideoResolution.FrameSize.Width, videoDevice.VideoResolution.FrameSize.Height, ref width, ref height);
            vispShoot.VideoSource = videoDevice;
            vispShoot.Height = height;
            vispShoot.Width = width;
            vispShoot.Start();
        }

        private void btnShoot_Click(object sender, System.EventArgs e)
        {
            Bitmap img = vispShoot.GetCurrentVideoFrame();
            if (null == img)
            {
                Common.ErrAlert("摄像头未正常打开或者正被占用！");
                return;
            }

            int h = FRAME_HEIGHT;
            int w = FRAME_WIDTH;
            Common.JustifyRectangle(img.Width, img.Height, ref w, ref h);
            Bitmap bitmap = Common.ZoomImage(img, h, w);
            picbPreview.Image = bitmap;
            picbPreview.Height = h;
            picbPreview.Width = w;

            ImageBase64 = Common.ImageToBase64(bitmap);
        }

        private void reader_button_Click(object sender, System.EventArgs e)
        {
            IDCardReaderResponse cardReaderResponse = JsonConvert.DeserializeObject<IDCardReaderResponse>(ReaderLib.ReadInfo());
            if (1 != cardReaderResponse.code)
            {
                Common.ErrAlert(cardReaderResponse.des);
                return;
            }
            idCardNumber_textBox.Text = cardReaderResponse.info.idcode;
            workerName_textBox.Text = cardReaderResponse.info.name;
            address_textBox.Text = cardReaderResponse.info.address;
            startTime_textBox.Text = cardReaderResponse.info.startdate;
            endTime_textBox.Text = cardReaderResponse.info.enddate;
            is_sue_textBox.Text = cardReaderResponse.info.department;
            nationName_textBox.Text = cardReaderResponse.info.nation;
            idcardNumber_pictureBox.BackgroundImage = Common.Base64ToImg(cardReaderResponse.info.photo);
        }

        private void submit_button_Click(object sender, System.EventArgs e)
        {
            if (string.Empty.Equals(idCardNumber_textBox.Text) ||
                string.Empty.Equals(workerName_textBox.Text) ||
                string.Empty.Equals(address_textBox.Text) ||
                string.Empty.Equals(startTime_textBox.Text) ||
                string.Empty.Equals(endTime_textBox.Text) ||
                string.Empty.Equals(is_sue_textBox.Text) ||
                string.Empty.Equals(nationName_textBox.Text) ||
                null == idcardNumber_pictureBox.BackgroundImage
                )
            {
                Common.ErrAlert("请先读取二代身份证后再提交！");
                return;
            }
            if (null == picbPreview.Image)
            {
                Common.ErrAlert("请先抓拍人员现场照后再提交！");
                return;
            }
            ImageBase64 = Common.ImageToBase64(picbPreview.Image);
            CommonResponseData commonResponse = new CommonResponseData();
            ManagerAddRequestData workerAddRequestData = new ManagerAddRequestData
            {
                idCardPhoto = Common.ImageToBase64(idcardNumber_pictureBox.BackgroundImage),
                idCardNumber = idCardNumber_textBox.Text.Trim(),
                ocvFace = ImageBase64,
                idCardType = 1,
                workerName = workerName_textBox.Text.Trim(),
                nation = Common.GetNationNum(nations, nationName_textBox.Text.Trim()).num.ToString(),
                address = address_textBox.Text.Trim(),
                isSue = is_sue_textBox.Text.Trim(),
                startTime = startTime_textBox.Text.Trim(),
                endTime = endTime_textBox.Text.Trim().Equals("长期") ? "99991231" : endTime_textBox.Text.Trim(),
                projectCode = workerProjectInfo.projectCode,
                gender = Common.GetGenderFromIDCardNumber(idCardNumber_textBox.Text.Trim()).Equals("男") ? 0 : 1,
                birthday = Common.GetBirthdayFromIDCardNumber(idCardNumber_textBox.Text.Trim()),
                loginOrganizationCode = loginUser.OrganizationCode//新增的字段
            };
            ManagerRequestService.RequestAddAction(workerAddRequestData, loginUser, ref commonResponse);
            if (null != commonResponse)
            {
                if (commonResponse.success)
                    Common.SuccessAlert("操作成功！");
                else
                    Common.ErrAlert("操作失败！\n" + commonResponse.message);
                DialogResult = DialogResult.OK;
            }
            else
            {
                Common.SuccessAlert("操作异常，请联系管理员！");
                DialogResult = DialogResult.None;
            }
        }
    }
}
