using System;

namespace MinecraftMappings.Internal.Textures.Entity
{
    public class BedrockEntityTextureVersion : EntityTextureVersion
    {
        public string MapsToJavaId {get; set;}
        public Type MapsToJavaEntity {get; set;}
    }
}
