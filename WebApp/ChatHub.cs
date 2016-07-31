using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Collections.Concurrent;

namespace WebApp
{
    public class ChatHub : Hub
    {

        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            var time = DateTime.Now;
            Clients.All.addNewMessageToPage(name, message, time);
        }


        #region 2
       
        #endregion

    }
}