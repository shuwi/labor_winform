namespace LaborStackApp.Response
{
    public class WorkersResponse
    {
        public int code { get; set; }
        public string message { get; set; }
        public bool success { get; set; }
        public WorkerListResponseData data { get; set; }
    }
}
