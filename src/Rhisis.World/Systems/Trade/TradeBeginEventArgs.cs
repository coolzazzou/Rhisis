﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Rhisis.World.Systems.Trade
{
    public class TradeBeginEventArgs : TradeEventArgs
    {
        public int TargetId { get; }

        public TradeBeginEventArgs(int targetId)
        {
            TargetId = targetId;
        }

        public override bool CheckArguments()
        {
            return TargetId != 0;
        }
    }
}
