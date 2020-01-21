namespace LaborStackApp.Response
{
    public class LoginResponse
    {
        public LoginResponseData data { get; set; }
        public int code { get; set; }
        public string message { get; set; }
        public bool success { get; set; }
        public string token { get; set; }
    }
}
