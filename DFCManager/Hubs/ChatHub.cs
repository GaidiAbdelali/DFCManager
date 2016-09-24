using System;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace DFCManager.Hubs
{
    public class ChatHub : Hub
    {
        public void Send(string message)
        {
            // Call the broadcastMessage method to update clients.
            Clients.All.broadcastMessage(message);
        }

        public static void SendMessage(string msg)
        {
            var hubContext = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
            hubContext.Clients.All.broadcastMessage(msg);
        }

    }
}