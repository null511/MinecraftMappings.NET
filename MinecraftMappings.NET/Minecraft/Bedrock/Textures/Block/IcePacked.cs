using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class IcePacked : BedrockBlockTexture
    {
        public IcePacked() : base("Ice Packed")
        {
            AddVersion("ice_packed")
                .MapsToJavaBlock<Java.Textures.Block.PackedIce>();
        }
    }
}
