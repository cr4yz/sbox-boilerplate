using Sandbox;
using Sandbox.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boilerplate.UI
{
    [Library]
    public partial class BoilerplateHUD : Hud
    {
        public BoilerplateHUD()
        {
            if (!IsClient) return;

            RootPanel.StyleSheet.Load("/ui/Hud.scss");
            RootPanel.AddChild<ChatBox>();
        }
    }
}