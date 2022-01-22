using Microsoft.AspNetCore.SignalR;

namespace CollaborativePdfViewer.Hubs
{
    public class CollaborationHub : Hub
    {
        public async Task OpenPdf(string path)
        {
            await Clients.Others.SendAsync("OnOpenPdf",path);
        }
        public async Task GoToNextPage(string path)
        {
            await Clients.Others.SendAsync("OnGoToNextPage",path);
        }
        public async Task GoToPreviousPage(string user)
        {
            await Clients.Others.SendAsync("OnGoToPreviousPage",user);
        }
    }
}
