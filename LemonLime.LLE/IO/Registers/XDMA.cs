﻿using LemonLime.Common;
using LemonLime.LLE.Memory;

namespace LemonLime.LLE.IO.Registers
{
    class XDMA
    {
        public static void XDMA_UNKNOWN(Context Ctx)
        {
            Logger.WriteStub("Stubbed.");

            Ctx.SetOutput(0xFFFFFFFF);
        }
    }
}
