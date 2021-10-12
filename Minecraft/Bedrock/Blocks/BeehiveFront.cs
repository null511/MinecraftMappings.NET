﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeehiveFront : BedrockBlockData
    {
        public const string BlockId = "beehive_front";
        public const string BlockName = "Beehive Front";


        public BeehiveFront() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = Java.Textures.Block.BeehiveFront.BlockId,
            });
        }
    }
}
