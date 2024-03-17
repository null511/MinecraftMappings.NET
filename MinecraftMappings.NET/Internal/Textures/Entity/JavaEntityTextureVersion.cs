using System;

namespace MinecraftMappings.Internal.Textures.Entity
{
    public class JavaEntityTextureVersion : EntityTextureVersion
    {
        public string? MapsToBedrockId {get; set;}
        public Type? MapsToBedrockEntity {get; set;}
    }
}
