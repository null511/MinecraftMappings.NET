﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BigDripleafTop : JavaBlockTexture
    {
        public BigDripleafTop() : base("Big Dripleaf Top")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "big_dripleaf_top")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.BigDripleaf>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BellTop>();
        }
    }
}
