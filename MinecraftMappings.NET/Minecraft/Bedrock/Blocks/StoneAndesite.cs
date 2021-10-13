﻿using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class StoneAndesite : BedrockBlockTexture
    {
        public StoneAndesite() : base("Stone Andesite")
        {
            AddVersion("stone_andesite")
                .MapsToJavaBlock<Andesite>();
        }
    }
}
