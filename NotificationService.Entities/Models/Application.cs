using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotificationService.Entities.Models
{
    public class Application : BaseClass
    {
        public string ApplicationName { get; set; }
        public string SMTPUserName { get; set; }
        public string Password { get; set; }
        public string SmtpServer { get; set; }
        public string From { get; set; }
        public string UniqueKey { get; set; }
        public int Port { get; set; }
    }
}
