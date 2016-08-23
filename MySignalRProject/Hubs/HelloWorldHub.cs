using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MySignalRProject.Hubs
{
    public class HelloWorldHub : Hub
    {
        public override Task OnConnected()
        {
            return Clients.All.showMessage("OnConnected " + Context.ConnectionId);
        }
        public void HelloWorldEverybody(string message)
        {
            Clients.All.ShowMessage(message);
        }
    }
}