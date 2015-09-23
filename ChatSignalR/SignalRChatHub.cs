using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatSignalR
{
    public class SignalRChatHub:Hub
    {
        public void broadCastMessage(string msgFrom, string msg)
        {
            Clients.All.receiveMessage(msgFrom, msg);
        }
    }
}