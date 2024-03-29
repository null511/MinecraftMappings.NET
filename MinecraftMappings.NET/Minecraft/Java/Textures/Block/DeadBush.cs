﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadBush : JavaBlockTexture
    {
        public DeadBush() : base("Dead Bush")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_bush")
                .WithDefaultModel<Java.Models.Block.DeadBush>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deadbush>();
        }
    }
}
