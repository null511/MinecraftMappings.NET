using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ComparatorOn : BedrockBlockTexture
    {
        public ComparatorOn() : base("Comparator, On")
        {
            AddVersion("comparator_on")
                .MapsToJavaBlock<Java.Textures.Block.ComparatorOn>();
        }
    }
}
