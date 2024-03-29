﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlackTerracotta : JavaBlockTexture
    {
        public BlackTerracotta() : base("Black Terracotta")
        {
            AddVersion("black_terracotta")
                .WithDefaultModel<Java.Models.Block.BlackTerracotta>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HardenedClayStainedBlack>();
        }
    }
}
