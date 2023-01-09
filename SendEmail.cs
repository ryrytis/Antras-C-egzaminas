using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egzas1117
{
    public class SendEmail
    {
        public class EmailSetupData
        {
            public string EmailFrom { get; set; }
            public string EmailUserName { get; set; }
            public string EmailPassword { get; set; }
            public string EmailSmtpServerName { get; set; }
            public int EmailSmtpPortNumber { get; set; }
            public Boolean SSLActive { get; set; } = false;
        }

        public class SendingResultData
        {
            public string EmailTo { get; set; }
            public string SendingEmailSubject { get; set; }
            public DateTime SendingDateTime { get; set; }
            public Boolean SendingEmailSuccess { get; set; }
            public string SendingEmailMessage { get; set; }
        }
        public class SendingProcess
        {
            public string EmailCommonSubjectOptional { get; set; } = "";
            private EmailSetupData EmailSetupParam { get; set; }
            private string EmailBodyContent { get; set; }
            private Boolean IsEmailBodyHtml { get; set; }
            private string EmailAttachFilePath { get; set; }

            public SendingProcess(String MyEmailTextContent, String MyEmailAttachFilePath, EmailSetupData MyEmailSetupParam, Boolean EmailBodyHtml)
            {
                EmailBodyContent = MyEmailTextContent;
                EmailAttachFilePath = MyEmailAttachFilePath;
                EmailSetupParam = MyEmailSetupParam;
                IsEmailBodyHtml = EmailBodyHtml;
            }
        }
    }
}
