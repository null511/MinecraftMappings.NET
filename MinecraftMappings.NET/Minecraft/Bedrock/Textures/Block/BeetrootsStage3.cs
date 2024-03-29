﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BeetrootsStage3 : BedrockBlockTexture
    {
        public BeetrootsStage3() : base("Beetroots, Stage 3")
        {
            AddVersion("beetroots_stage3")
                .MapsToJavaBlock<Java.Textures.Block.Beetroots_Stage3>();
        }
    }
}
