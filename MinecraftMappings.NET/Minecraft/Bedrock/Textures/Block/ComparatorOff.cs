using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class ComparatorOff : BedrockBlockTexture
    {
        public ComparatorOff() : base("Comparator, Off")
        {
            AddVersion("comparator_off")
                .MapsToJavaBlock<Java.Textures.Block.Comparator>();
        }
    }
}
