using Microsoft.AspNetCore.SignalR;

namespace Blazor_WebAssembly_SignalR_1.Server
{
    public class TextHub : Hub
    {
        public async Task Send(string text)
        {
            await Clients.All.SendAsync("ReceiveInformation", text);
        }
    }
}
