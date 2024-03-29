﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownGlazedTerracotta : JavaBlockTexture
    {
        public BrownGlazedTerracotta() : base("Brown Glazed Terracotta")
        {
            AddVersion("brown_glazed_terracotta")
                .WithDefaultModel<Java.Models.Block.BrownGlazedTerracotta>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GlazedTerracottaBrown>();
        }
    }
}
