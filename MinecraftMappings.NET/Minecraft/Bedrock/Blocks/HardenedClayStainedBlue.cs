﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class HardenedClayStainedBlue : BedrockBlockTexture
    {
        public HardenedClayStainedBlue() : base("Hardened Clay Stained Blue")
        {
            AddVersion("hardened_clay_stained_blue")
                .MapsToJavaBlock<Java.Textures.Block.BlueTerracotta>();
        }
    }
}
