﻿using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchPlanks : JavaBlockData
    {
        public const string BlockId = "birch_planks";
        public const string BlockName = "Birch Planks";


        public BirchPlanks() : base(BlockName)
        {
            Versions.Add(new JavaBlockDataVersion {
                Id = BlockId,
                MapsToBedrockId = BedrockBlocks.PlanksBirch.BlockId,
            });
        }
    }
}
