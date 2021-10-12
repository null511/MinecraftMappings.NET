﻿using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackCandle_OneCandle_Lit : JavaModelData
    {
        public BlackCandle_OneCandle_Lit() : base("Black Candle, One Candle, Lit")
        {
            AddVersion("black_candle_one_candle_lit", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_candle")
                .AddTexture("all", "block/black_candle_lit");
        }
    }
}
