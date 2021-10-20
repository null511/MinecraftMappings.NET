using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Comparator : JavaBlockTexture
    {
        public Comparator() : base("Comparator")
        {
            AddVersion("comparator")
                .WithDefaultModel<Java.Models.Block.Comparator>();
                //.MapsToBedrockBlock<BedrockBlocks.Comparator>();
        }
    }
}
