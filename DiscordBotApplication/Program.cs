using DSharpPlus;
using Microsoft.Extensions.Configuration;
using DiscordBotApplication;

var source = new CancellationTokenSource();

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", true)
    .AddUserSecrets(typeof(Program).Assembly, true)
    .Build();

var client = new DiscordClient(new DiscordConfiguration
{
    Token = config["discordtoken"],
    TokenType = TokenType.Bot
});

client.AddSuttonBot();

var token = source.Token;
await client.ConnectAsync();

while (!token.IsCancellationRequested)
{
    await Task.Delay(100);
}
