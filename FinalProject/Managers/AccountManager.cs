using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Managers
{
    public class AccountManager
    {
        private readonly SmtpClient _sender;
        private readonly Random _random;
        private readonly string _senderEmail;
        private readonly string _message;
        private readonly string _senderPassword;



        public string ConfirmationCode { get;}
        

        
        public AccountManager(string host,int port)
        {
            _sender = new SmtpClient(host,port)
            {
                Credentials = new NetworkCredential(_senderEmail, _senderPassword ),
                EnableSsl = true
            };
            _random = new Random();
            _senderEmail = "testingcsharp44@gmail.com";
            _message = GenerateMessage(GenerateCode().ToString());
            _senderPassword = "csharptester";
        }

        public void SendMail(string emailTo, string subject)
        {
          
           _sender.Send( _senderEmail, emailTo, subject, _message);
        }

        private string GenerateCode()
        {
            string code = new Random().Next(1000, 9999).ToString();
            ConfirmationCode = code;
            return code;
        }
        private string GenerateMessage(string code)
        {
          return  $"Hello, dear User! Confirmation code is {code}";
        }
    }
}
