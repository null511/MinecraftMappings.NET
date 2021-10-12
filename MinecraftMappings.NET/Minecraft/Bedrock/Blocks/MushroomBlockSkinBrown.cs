﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Blocks;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class MushroomBlockSkinBrown : BedrockBlockData
    {
        public const string BlockId = "mushroom_block_skin_brown";
        public const string BlockName = "Mushroom Block Skin Brown";


        public MushroomBlockSkinBrown() : base(BlockName)
        {
            AddVersion(BlockId, version => {
                version.MapsToJavaId = BrownMushroomBlock.BlockId;
            });
        }
    }
}