using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Pluto
{
    public static class Extensions
    {
        public static Command ToCommand(this char @this)
        {
            if (@this == 'F') return Command.Forward;
            if (@this == 'B') return Command.Backward;
            if (@this == 'L') return Command.Left;
            if (@this == 'R') return Command.Right;
            throw new InvalidOperationException("Cannot find");
        }
    }
}
