using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Features;
using Discord;
using DiscordInteraction.Discord;
using MEC;

using static DiscordInteraction.Variables.Protocol;
using static DiscordInteraction.IEnumerators.ServerManagers;

namespace DiscordInteraction
{
    public class DiscordInteraction : Plugin<Config>
    {
        public static DiscordInteraction Instance;

        public override string Name => "DiscordInteraction";
        public override string Author => "GoldenPig1205";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(1, 2, 0, 5);

        public override void OnEnabled()
        {
            Instance = this;
            base.OnEnabled();

            WebhookURL = Config.WebhookURL;
            BotAPIServer = Config.BotAPIServer;

            Webhook webhook = new Webhook();
            webhook.OnEnabled();

            Command command = new Command();
            command.OnEnabled();

            Timing.RunCoroutine(SendHeartbeat());
        }

        public override void OnDisabled()
        {
            base.OnDisabled();
            Instance = null;
        }
    }
}
