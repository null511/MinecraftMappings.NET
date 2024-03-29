﻿using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaLeaves : JavaBlockModel
    {
        public AcaciaLeaves() : base("Acacia Leaves")
        {
            AddVersion("acacia_leaves", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/leaves")
                .AddTexture("all", "block/acacia_leaves");
        }
    }
}
