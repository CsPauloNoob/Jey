using DSharpPlus.Entities;
using DSharpPlus;
using DSharpPlus.SlashCommands;
using Jey.Domain.Services;

namespace Jey.Application
{
    public class SlashMainMenu : ApplicationCommandModule
    {
        private readonly UserService _userService;

        SlashMainMenu(UserService userService)
        {
            _userService = userService;
        }



        [SlashCommand("menu", "menu inicial")]
        async Task Menu(InteractionContext ctx)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            var message = _userService.Message();

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(message));

        }



        [SlashCommand("car", "a car")]
        async Task Car(InteractionContext ctx)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            var message = _userService.Message();

            await ctx.EditResponseAsync(new DiscordWebhookBuilder().WithContent(message));
        }



        [SlashCommand("Registrar", "Olá, registre-se aqui")]
        async Task Register(InteractionContext ctx)
        {
            await ctx.CreateResponseAsync(InteractionResponseType.DeferredChannelMessageWithSource);

            if(_userService.Register(ctx.User.Id, ctx.User.Username).Result)
            {
                new DiscordWebhookBuilder().WithContent("registrado com sucesso");
            }

        }
    }
}