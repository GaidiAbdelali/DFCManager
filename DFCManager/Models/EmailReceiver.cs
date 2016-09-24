using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Diagnostics;
using S22.Imap;
using System.Threading;
using System.Text.RegularExpressions;
using DFCManager.Hubs; 

namespace DFCManager.Models
{
    public class EmailReceiver
    {
        private static AutoResetEvent ReconnectEvent = new AutoResetEvent(false);
        private static ImapClient Client;

        public static EmailAnalyser emailAnalyser = new EmailAnalyser();

        //main thread for emails reception
        public static void getEmailWhenReceived()
        {
            try
            {
                while (true)
                {
                    Debug.WriteLine("Connecting...");
                    InitializeClient("","");
                    Debug.WriteLine("Connected");
                    ReconnectEvent.WaitOne();
                }
            }
            finally
            {
                if (Client != null)
                Client.Dispose();
            }
        }
 
        //handle the connection to an email account
        private static void InitializeClient(string login,string password)
        {
            //if already connected to a user account dispose.
            if (Client != null)
                Client.Dispose();
            
            //if not create a connection
            Client = new ImapClient("imap.gmail.com", 993, login, password, AuthMethod.Login, true);

            //Setup events handlers.
            Client.NewMessage += NewMessage;
            Client.IdleError += IdleError;
        }
 
        //message reception evant handler
        private static void NewMessage(object sender, IdleMessageEventArgs e)
        {
            emailAnalyser.DFCEmailAnalysis(Client.GetMessage(e.MessageUID));
            
            DFCManager.Hubs.ChatHub.SendMessage("well recieved");

        }

        //error handler
        private static void IdleError(object sender, IdleErrorEventArgs e)
        {
            Debug.WriteLine("An error occurred while idling: " + e.Exception.Message);
            ReconnectEvent.Set();
        }
    
    }
}