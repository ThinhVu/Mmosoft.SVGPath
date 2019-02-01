﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SVGPathExplain.CmdConverter
{
    class RelativeHorizontalLineCmdConverter : ICmdConverter
    {
        public Cmd[] Convert(Cmd c, Cmd prevC, ref float absX, ref float absY)
        {
            List<Cmd> cmds = new List<Cmd>();
            Cmd cmd = new Cmd { CmdText = "H", X = absX, Y = absY };
            cmd.Params.Add(absX + c.Params[0]);
            absX += c.Params[0];
            cmds.Add(cmd);
            return cmds.ToArray();
        }
    }
}