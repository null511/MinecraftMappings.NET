﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CakeInner : JavaBlockTexture
    {
        public CakeInner() : base("Cake Inner")
        {
            AddVersion("cake_inner")
                .WithDefaultModel<Java.Models.Block.Cake_Slice1>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CakeBottom>();
        }
    }
}
