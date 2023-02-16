using Microsoft.AspNetCore.SignalR;
using System.Linq;

public class ChatHub : Hub
{
    // 用戶連線 ID 列表
    public static List<Users> ConnIDList = new List<Users>();

    /// <summary>
    /// 連線事件
    /// </summary>
    /// <returns></returns>
    public override async Task OnConnectedAsync()
    {
        // 加入ConnectionID 
        if (ConnIDList.Where(p => p.ID == Context.ConnectionId).FirstOrDefault() == null)
        {
            ConnIDList.Add(new Users() { ID = Context.ConnectionId });
        }

        // 更新連線 ID 列表
        string jsonString = System.Text.Json.JsonSerializer.Serialize(ConnIDList);
        await Clients.All.SendAsync("UpdList", jsonString);

        // 更新個人 ID
        await Clients.Client(Context.ConnectionId).SendAsync("UpdSelfID", Context.ConnectionId);


        await base.OnConnectedAsync();
    }

    /// <summary>
    /// 離線事件
    /// </summary>
    /// <param name="ex"></param>
    /// <returns></returns>
    public override async Task OnDisconnectedAsync(Exception? ex)
    {
        // 移除ConnectionID 
        var user = ConnIDList.Where(p => p.ID == Context.ConnectionId).FirstOrDefault();
        if (user != null)
        {
            ConnIDList.Remove(user);
        }

        // 更新連線 ID 列表
        string jsonString = System.Text.Json.JsonSerializer.Serialize(ConnIDList);
        await Clients.All.SendAsync("UpdList", jsonString);

        // 更新聊天內容
        await Clients.All.SendAsync("UpdContent", $"{user.Name} 離開聊天室 ");

        await base.OnDisconnectedAsync(ex);
    }

    /// <summary>
    /// 傳遞訊息
    /// </summary>
    /// <param name="user"></param>
    /// <param name="message"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    public async Task SendMessage(string message)
    {
        var self = ConnIDList.Where(p => p.ID == Context.ConnectionId).FirstOrDefault();
        string ret = $"{self.Name} 說 ： {message}";
        
        // 更新聊天內容
        await Clients.All.SendAsync("UpdContent", ret);
    }
    /// <summary>
    /// 設定暱稱
    /// </summary>
    /// <param name="Name"></param>
    /// <returns></returns>
    public async Task SetUserInfo(string Name)
    {
        ConnIDList.Where(p => p.ID == Context.ConnectionId).First().Name = Name;
        // 更新連線 ID 列表
        string jsonString = System.Text.Json.JsonSerializer.Serialize(ConnIDList);
        await Clients.All.SendAsync("UpdList", jsonString);

        // 更新聊天內容
        await Clients.All.SendAsync("UpdContent", $"{Name} 進入聊天室 ");

    }
}