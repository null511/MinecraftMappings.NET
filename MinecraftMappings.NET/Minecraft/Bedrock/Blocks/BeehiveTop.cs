﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeehiveTop : BedrockBlockData
    {
        public const string BlockId = "beehive_top";
        public const string BlockName = "Beehive Top";


        public BeehiveTop() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = BeehiveEnd.BlockId,
            });
        }
    }
}