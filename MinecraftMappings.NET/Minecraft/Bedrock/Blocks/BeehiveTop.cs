﻿using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeehiveTop : BedrockBlockTexture
    {
        public BeehiveTop() : base("Beehive Top")
        {
            AddVersion("beehive_top")
                .MapsToJavaBlock<BeehiveEnd>();
        }
    }
}
