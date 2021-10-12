﻿using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlastFurnaceFrontOn : JavaBlockData
    {
        public const string BlockId = "blast_furnace_front_on";
        public const string BlockName = "Blast Furnace Front On";


        public BlastFurnaceFrontOn() : base(BlockName)
        {
            Versions.Add(new JavaBlockDataVersion {
                Id = BlockId,
                MapsToBedrockId = BedrockBlocks.BlastFurnaceFrontOn.BlockId,
                FrameCount = 2,
            });
        }
    }
}
