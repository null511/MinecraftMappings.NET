﻿using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CauldronBottom : JavaBlockData
    {
        public CauldronBottom() : base("Cauldron, Bottom")
        {
            AddVersion("cauldron_bottom")
                .WithDefaultModel<Java.Models.Block.Cauldron>();
                //.MapsToBedrockBlock<BedrockBlocks.CauldronBottom>();
        }
    }
}