namespace Mail
{
    public class MailModel
    {
        public string SmptServer { get; set; }
        public string From { get; set; }
        public string Password { get; set; }
        public string To { get; set; }
        public string Message { get; set; }
        public string AttachFile { get; set; }
        public string Caption { get; set; }
    }
}
