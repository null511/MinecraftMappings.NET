﻿using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OrientableWithBottom : JavaBlockModel
    {
        public OrientableWithBottom() : base("Orientable, With Bottom")
        {
            AddVersion("orientable_with_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube")
                .AddTexture("up", "#top")
                .AddTexture("down", "#bottom")
                .AddTexture("north", "#front")
                .AddTexture("south", "#side")
                .AddTexture("west", "#side")
                .AddTexture("east", "#side");
        }
    }
}
