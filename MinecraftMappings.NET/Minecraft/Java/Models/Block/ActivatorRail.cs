﻿using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ActivatorRail : JavaBlockModel
    {
        public ActivatorRail() : base("Activator Rail")
        {
            AddVersion("activator_rail", "1.5")
                .WithPath("models/block")
                .WithParent("block/rail_flat")
                .AddTexture("rail", "block/activator_rail");
        }
    }
}
