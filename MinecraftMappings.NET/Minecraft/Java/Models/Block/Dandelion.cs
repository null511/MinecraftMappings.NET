﻿using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Dandelion : JavaBlockModel
    {
        public Dandelion() : base("Dandelion")
        {
            AddVersion("dandelion", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/dandelion");
        }
    }
}
