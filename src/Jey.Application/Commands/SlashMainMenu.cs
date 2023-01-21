using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.SlashCommands;


namespace Jey.Application.Commands
{
    internal class SlashMainMenu : ApplicationCommandModule
    {
        [SlashCommand("test", "test")]
        async Task TestCommand(InteractionContext stx)
        {
            await stx.CreateResponseAsync(InteractionResponseType.Pong, new DiscordInteractionResponseBuilder()
                    .WithContent("Teste")
                    .WithTitle("Teste")
                    .AsEphemeral(true));
        }
    }
}
