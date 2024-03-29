﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class RailActivatorPowered : BedrockBlockTexture
    {
        public RailActivatorPowered() : base("Rail Activator, Powered")
        {
            AddVersion("rail_activator_powered")
                .MapsToJavaBlock<Java.Textures.Block.ActivatorRailOn>();
        }
    }
}
