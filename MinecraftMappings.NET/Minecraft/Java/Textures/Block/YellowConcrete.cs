﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowConcrete : JavaBlockTexture
    {
        public YellowConcrete() : base("Yellow Concrete")
        {
            AddVersion("yellow_concrete")
                .WithMinVersion("1.12")
                .WithDefaultModel<Java.Models.Block.YellowConcrete>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ConcreteYellow>();
        }
    }
}
