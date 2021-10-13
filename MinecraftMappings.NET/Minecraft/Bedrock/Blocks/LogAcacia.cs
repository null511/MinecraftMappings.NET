﻿using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class LogAcacia : BedrockBlockTexture
    {
        public LogAcacia() : base("Log Acacia")
        {
            AddVersion("log_acacia")
                .MapsToJavaBlock<AcaciaLog>();
        }
    }
}
