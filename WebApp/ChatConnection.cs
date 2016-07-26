using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace WebApp
{
    public class ChatConnection : PersistentConnection
    {
        protected override Task OnConnected(IRequest request, string connectionId)
        {
            return Connection.Send(connectionId, request.QueryString + "Welcome!"   );
        }

        protected override Task OnReceived(IRequest request, string connectionId, string data)
        {
            return Connection.Broadcast(data);
        }
    }
}