using DSharpPlus;
using DSharpPlus.SlashCommands;
using Jey.Application;
using Jey.DI;
using Microsoft.Extensions.DependencyInjection;

namespace Jey.StartUp
{
    public class Start
    {

        public Start()
        {
            var services = new ServiceCollection();
            BootStrap.Configure(services);

            var client = ConfigureClient().GetAwaiter().GetResult();

            RunBot(client).GetAwaiter().GetResult();
        }

        async Task<DiscordClient> ConfigureClient()
        {

            var Client = new DiscordClient(new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                AutoReconnect = true,
                Token = Environment.GetEnvironmentVariable("BOT_TEST", EnvironmentVariableTarget.User),
                TokenType = TokenType.Bot
            });

            var slash = Client.UseSlashCommands();
            slash.RegisterCommands<SlashMainMenu>();

            return await Task.FromResult(Client);
        }

        async Task RunBot(DiscordClient client)
        {
            await client.ConnectAsync();
            Console.WriteLine("ON");
            await Task.Delay(-1);
        }
    }
}