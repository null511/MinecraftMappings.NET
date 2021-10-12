﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class ConcreteBlack : BedrockBlockData
    {
        public const string BlockId = "concrete_black";
        public const string BlockName = "Concrete Black";


        public ConcreteBlack() : base(BlockName)
        {
            AddVersion(BlockId, version => {
                version.MapsToJavaId = BlackConcrete.BlockId;
            });
        }
    }
}
