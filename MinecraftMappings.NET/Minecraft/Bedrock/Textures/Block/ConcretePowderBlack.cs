﻿using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ConcretePowderBlack : BedrockBlockTexture
    {
        public ConcretePowderBlack() : base("Concrete Powder Black")
        {
            AddVersion("concrete_powder_black")
                .MapsToJavaBlock<BlackConcretePowder>();
        }
    }
}
