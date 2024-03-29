﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchSapling : JavaBlockTexture
    {
        public BirchSapling() : base("Birch Sapling")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("birch_sapling")
                .WithDefaultModel<Java.Models.Block.BirchSapling>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SaplingBirch>();
        }
    }
}
