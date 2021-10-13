using System;

namespace MinecraftMappings.Internal.Textures.Block
{
    public class BedrockBlockTextureVersion : BlockTextureVersion
    {
        public string MapsToJavaId {get; set;}
        public Type MapsToJavaBlock {get; set;}
    }
}
