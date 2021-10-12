﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class PlanksAcacia : BedrockBlockData
    {
        public const string BlockId = "planks_acacia";
        public const string BlockName = "Planks Acacia";


        public PlanksAcacia() : base(BlockName)
        {
            Versions.Add(new BedrockBlockDataVersion {
                Id = BlockId,
                MapsToJavaId = AcaciaPlanks.BlockId,
            });
        }
    }
}