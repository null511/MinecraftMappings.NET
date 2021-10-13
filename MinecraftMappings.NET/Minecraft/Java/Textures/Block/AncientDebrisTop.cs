﻿using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AncientDebrisTop : JavaBlockTexture
    {
        public AncientDebrisTop() : base("Ancient Debris, Top")
        {
            AddVersion("ancient_debris_top")
                .WithMinVersion("1.16")
                .WithDefaultModel<Java.Models.Block.AncientDebris>()
                .MapsToBedrockBlock<BedrockBlocks.AncientDebrisTop>();
        }
    }
}
