﻿using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeeNestBottom : JavaBlockData
    {
        public const string BlockId = "bee_nest_bottom";
        public const string BlockName = "Bee Nest Bottom";


        public BeeNestBottom() : base(BlockName)
        {
            Versions.Add(new JavaBlockDataVersion {
                Id = BlockId,
                MapsToBedrockId = BedrockBlocks.BeeNestBottom.BlockId,
            });
        }
    }
}
