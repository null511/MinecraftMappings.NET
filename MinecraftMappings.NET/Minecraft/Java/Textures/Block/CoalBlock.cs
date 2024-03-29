﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CoalBlock : JavaBlockTexture
    {
        public CoalBlock() : base("Coal Block")
        {
            AddVersion("coal_block")
                .WithDefaultModel<Java.Models.Block.CoalBlock>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CoalBlock>();
        }
    }
}
