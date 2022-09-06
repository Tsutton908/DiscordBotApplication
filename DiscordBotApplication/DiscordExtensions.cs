using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSharpPlus;

namespace DiscordBotApplication
{
    public static class DiscordExtensions
    {
        private static SuttonBot? _TheBot;
        public static DiscordClient AddSuttonBot(this DiscordClient client)
        {
            _TheBot = new SuttonBot();
            _TheBot.Initialize(client);

            return client;
        }
    }
}
