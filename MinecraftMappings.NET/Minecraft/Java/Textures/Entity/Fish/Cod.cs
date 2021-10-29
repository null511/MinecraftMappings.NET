﻿using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Cod : JavaEntityTexture
    {
        public Cod() : base("Cod")
        {
            AddVersion("cod")
                .WithDefaultModel<Java.Models.Entity.Cod>();
                //.MapsToBedrockEntity<BedrockEntities.Cod>();
        }
    }
}
