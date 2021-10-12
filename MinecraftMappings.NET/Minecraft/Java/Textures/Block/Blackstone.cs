﻿using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Blackstone : JavaBlockData
    {
        public const string BlockId = "blackstone";
        public const string BlockName = "Blackstone";


        public Blackstone() : base(BlockName)
        {
            Versions.Add(new JavaBlockDataVersion {
                Id = BlockId,
                MapsToBedrockId = BedrockBlocks.Blackstone.BlockId,
            });
        }
    }
}