﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class RailActivator : BedrockBlockData
    {
        public const string BlockId = "rail_activator";
        public const string BlockName = "Rail Activator";


        public RailActivator() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = ActivatorRail.BlockId,
            });
        }
    }
}
