using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace BlazorSignalRTest
{
	[Authorize]
	public class ChatHub : Hub
	{
		public async Task SendMessage(string message)
		{
			await Clients.All.SendAsync("MESSAGE_RECEIVED", $"Server: {message}");
		}
	}
}
