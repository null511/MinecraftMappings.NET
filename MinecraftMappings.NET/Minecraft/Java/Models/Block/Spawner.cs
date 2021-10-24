﻿using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Spawner : JavaBlockModel
    {
        public Spawner() : base("Spawner")
        {
            AddVersion("spawner", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/spawner");
        }
    }
}
