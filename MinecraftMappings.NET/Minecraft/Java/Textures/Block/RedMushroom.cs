﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedMushroom : JavaBlockTexture
    {
        public RedMushroom() : base("Red Mushroom")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("red_mushroom")
                .WithDefaultModel<Java.Models.Block.RedMushroom>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MushroomRed>();
        }
    }
}
