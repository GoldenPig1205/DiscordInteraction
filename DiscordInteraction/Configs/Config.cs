using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.API.Interfaces;

namespace DiscordInteraction
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public string WebhookURL { get; set; } = "WebhookURL";
        public string BotAPIServer { get; set; } = "http://127.0.0.1:?????/";
    }
}
