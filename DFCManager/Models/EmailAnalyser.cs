using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace DFCManager.Models
{
    public class EmailAnalyser
    {
        public void DFCEmailAnalysis(MailMessage msg)
        {
            String[] parts = Regex.Split(msg.Body, "(\r\n\r\n)");
            parts = parts.Where(val => Regex.Matches(val, @"[a-zA-Z]").Count != 0).ToArray();
            

        }
        
    }
}