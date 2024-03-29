﻿using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ActivatorRail_RaisedSW : JavaBlockModel
    {
        public ActivatorRail_RaisedSW() : base("Activator Rail, Raised SW")
        {
            AddVersion("activator_rail_raised_sw", "1.5")
                .WithPath("models/block")
                .WithParent("block/template_rail_raised_sw")
                .AddTexture("rail", "block/activator_rail");
        }
    }
}
