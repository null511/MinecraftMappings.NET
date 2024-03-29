﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteConcrete : JavaBlockTexture
    {
        public WhiteConcrete() : base("White Concrete")
        {
            AddVersion("white_concrete")
                .WithMinVersion("1.12")
                .WithDefaultModel<Java.Models.Block.WhiteConcrete>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteWhite>();
        }
    }
}
