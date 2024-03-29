﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ConcretePowderBlue : BedrockBlockTexture
    {
        public ConcretePowderBlue() : base("Concrete Powder Blue")
        {
            AddVersion("concrete_powder_blue")
                .MapsToJavaBlock<Java.Textures.Block.BlueConcretePowder>();
        }
    }
}
