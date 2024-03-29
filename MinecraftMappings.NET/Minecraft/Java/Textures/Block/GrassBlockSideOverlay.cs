﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GrassBlockSideOverlay : JavaBlockTexture
    {
        public GrassBlockSideOverlay() : base("Grass Block, Side Overlay")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("grass_block_side_overlay")
                .WithDefaultModel<Java.Models.Block.GrassBlock>();
                //.MapsToBedrockBlock<BedrockBlocks.Grass>();
        }
    }
}
