﻿using Microsoft.CodeAnalysis.Elfie.Model.Strings;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;

namespace PrimaryConnect.Data
{
    public class UsefulFunctions
    {
        static  public string GenerateandSendKey(string Email)
        {
            string fMail = "";
            
            MailMessage mailMessage = new MailMessage();
            mailMessage.From=new MailAddress(Email);
            mailMessage.Subject = "Confermation key";
            mailMessage.To.Add(Email);
            int num = Convert.ToInt32(RandomNumberGenerator.Create());
            mailMessage.Body = (num%1000000).ToString();
            mailMessage.IsBodyHtml=false;
            string szzezz = "";
            SmtpClient smtpClient = new SmtpClient("satp-mail.outlook.com")
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(fMail, szzezz)
                ,Port=587

            };
            smtpClient.Send(mailMessage);   
            return num.ToString();
        }
    }
}
