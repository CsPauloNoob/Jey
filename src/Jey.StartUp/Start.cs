using DSharpPlus;
using DSharpPlus.CommandsNext;
using DSharpPlus.SlashCommands;
using Jey.Application.Commands;
using Jey.Application.Commands.TextCommands;
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

            var client = ConfigureClient(services).GetAwaiter().GetResult();

            RunBot(client).GetAwaiter().GetResult();
        }

        async Task<DiscordClient> ConfigureClient(ServiceCollection services)
        {

            var Client = new DiscordClient(new DiscordConfiguration()
            {
                Intents = DiscordIntents.All,
                AutoReconnect = true,
                Token = Environment.GetEnvironmentVariable("BOT_TEST"),
                TokenType = TokenType.Bot
            });

            var cmd = Client.UseCommandsNext(new CommandsNextConfiguration()
            {
                StringPrefixes = new[] { "!" },
                Services = services.BuildServiceProvider()
            }) ;

            var slash = Client.UseSlashCommands(new SlashCommandsConfiguration
            {
                Services = services.BuildServiceProvider()
            });

            slash.RegisterCommands<SlashMainMenu>();
            cmd.RegisterCommands<TextCommand>();

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