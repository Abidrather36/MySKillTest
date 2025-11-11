namespace MySkillTest.Application.Utils
{
    public class EmailSettings
    {
        public string SmtpHost { get; set; }=string.Empty;
        public int SmtpPort { get; set; }
        public string From { get; set; } = string.Empty;
        public string To { get; set; } = string.Empty;
        public string ErrorTo { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public bool SendErrorMail { get; set; } 
        public bool AllowSendEmails { get; set; }
        public string PortalURL { get; set; } = string.Empty;
        public string APIURL { get; set; } = string.Empty;
        public string FromMail { get; set; } = string.Empty;
        public string QuestionMail { get; set; } = string.Empty;
        public string AppName { get; set; } = string.Empty;
    }

}
