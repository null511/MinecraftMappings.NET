﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LogAcacia : BedrockBlockTexture
    {
        public LogAcacia() : base("Log Acacia")
        {
            AddVersion("log_acacia")
                .MapsToJavaBlock<Java.Textures.Block.AcaciaLog>();
        }
    }
}
