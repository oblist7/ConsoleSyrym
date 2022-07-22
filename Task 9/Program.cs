/*
 *Task 9) Применение Ping для проверки сайта работаетли
 * 
 * async await
 * 
 */

using System.Net.NetworkInformation;

string url = "https://google.com";

await IsWebSiteAlive(url);

async Task<bool> IsWebSiteAlive(string url)
{
    Ping ping = new Ping();
    string host = new Uri(url).Host;

    PingReply result = await ping.SendPingAsync(host);
    return result.Status == IPStatus.Success;
}
