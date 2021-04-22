using Sandbox;
using Boilerplate.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boilerplate
{
    [Library("boilerplate", Title = "Boilerplate Addon")]
    partial class BoilerplateGame : Game
    {
        public BoilerplateGame()
        {
            Log.Info("Boilerplate Game Started");
            if (IsServer)
			{
				new BoilerplateHUD();
			}
        }

        public override Player CreatePlayer() => new BoilerplatePlayer();
    }
}
