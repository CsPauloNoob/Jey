using System;
using System.Collections.Generic;
using System.Linq;
using Jey.Domain.Services;
using DSharpPlus.CommandsNext;
using System.Threading.Tasks;
using DSharpPlus.CommandsNext.Attributes;

namespace Jey.Application.Commands
{
    public class TextCommand : BaseCommandModule
    {

        private readonly UserService _userService;

        public TextCommand(UserService userService)
        {
            _userService = userService;
        }


        [Command("Registrar")]
        async Task Registrar(CommandContext ctx)
        {
            _userService.Register(ctx.User.Id, ctx.User.Username)
                .GetAwaiter().GetResult();

            await ctx.RespondAsync("Ok");
        }
    }
}
