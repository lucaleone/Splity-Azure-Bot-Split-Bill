using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Schema;

namespace EchoBotWithCounter.States
{
    public class WelcomeUserState
    {
        public bool DidBotWelcomeUser { get; set; } = false;
    }
}
