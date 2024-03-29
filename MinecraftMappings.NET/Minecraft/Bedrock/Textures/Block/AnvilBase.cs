﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class AnvilBase : BedrockBlockTexture
    {
        public AnvilBase() : base("Anvil Base")
        {
            AddVersion("anvil_base")
                .MapsToJavaBlock<Java.Textures.Block.Anvil>();
        }
    }
}
