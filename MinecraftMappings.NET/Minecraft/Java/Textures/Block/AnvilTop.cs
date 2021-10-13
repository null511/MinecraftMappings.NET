﻿using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AnvilTop : JavaBlockTexture
    {
        public AnvilTop() : base("Anvil, Top")
        {
            AddVersion("anvil_top")
                .WithDefaultModel<Java.Models.Block.Anvil>();
                //version.MapsToBedrockBlock = typeof(BedrockBlocks.AnvilTop);
        }
    }
}
