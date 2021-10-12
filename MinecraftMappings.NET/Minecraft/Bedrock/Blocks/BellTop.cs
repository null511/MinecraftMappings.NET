﻿using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BellTop : BedrockBlockData
    {
        public const string BlockId = "bell_top";
        public const string BlockName = "Bell Top";


        public BellTop() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaBlock = typeof(Java.Textures.Block.BellTop),
            });
        }
    }
}