using System;
using System.Net.WebSockets;
using System.Threading.Tasks;
using AspNet.Api.Websocket.WebApp.Websocket;

namespace AspNet.Api.Websocket.WebApp.Middlewares
{
    public class NotificationsMessageHandler :  WebSocketHandler
    {
        public NotificationsMessageHandler(WebSocketConnectionManager webSocketConnectionManager) : base(webSocketConnectionManager)
        {
        }

        public override Task ReceiveAsync(WebSocket socket, WebSocketReceiveResult result, byte[] buffer)
        {
            throw new NotImplementedException();
        }
    }
}