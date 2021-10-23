﻿using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HopperOutside : JavaBlockTexture
    {
        public HopperOutside() : base("Hopper Outside")
        {
            AddVersion("hopper_outside")
                .WithMinVersion("1.5")
                .WithDefaultModel<Java.Models.Block.Hopper>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HopperOutside>();
        }
    }
}
