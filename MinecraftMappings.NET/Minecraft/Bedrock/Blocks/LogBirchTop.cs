﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class LogBirchTop : BedrockBlockData
    {
        public const string BlockId = "log_birch_top";
        public const string BlockName = "Log Birch Top";


        public LogBirchTop() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = BirchLogTop.BlockId,
            });
        }
    }
}