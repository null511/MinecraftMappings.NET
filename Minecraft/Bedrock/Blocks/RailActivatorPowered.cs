﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class RailActivatorPowered : BedrockBlockData
    {
        public const string BlockId = "rail_activator_powered";
        public const string BlockName = "Rail Activator Powered";


        public RailActivatorPowered() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = ActivatorRailOn.BlockId,
            });
        }
    }
}
