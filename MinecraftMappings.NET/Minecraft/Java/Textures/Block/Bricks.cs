﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Bricks : JavaBlockTexture
    {
        public Bricks() : base("Bricks")
        {
            AddVersion("bricks")
                .WithDefaultModel<Java.Models.Block.Bricks>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Brick>();
        }
    }
}
