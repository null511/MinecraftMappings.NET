﻿using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AttachedMelonStem : JavaBlockTexture
    {
        public AttachedMelonStem() : base("Attached Melon Stem")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("attached_melon_stem")
                .WithDefaultModel<Java.Models.Block.AttachedMelonStem>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MelonStemConnected>();
        }
    }
}
