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
        public string NewReleaseUpdateMessage { get; set; } = $"<b><size=25>새 릴리즈가 업데이트되었습니다!</size></b>\n<size=20>이 패치는 다음 라운드부터 적용되며, <color=#7289da>Discord</color>에서 관련 내용을 확인할 수 있습니다.</size>";
    }
}
