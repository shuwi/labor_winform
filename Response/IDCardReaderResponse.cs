namespace LaborStackApp.Response
{
    public class IDCardReaderResponse
    {
        public int code { get; set; }
        public string des { get; set; }
        public IDCardReaderUserInfo info { get; set; }
    }
}
