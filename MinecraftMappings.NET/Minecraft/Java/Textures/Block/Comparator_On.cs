using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Comparator_On : JavaBlockTexture
    {
        public Comparator_On() : base("Comparator, On")
        {
            AddVersion("comparator_on")
                .WithDefaultModel<Java.Models.Block.Comparator_On>();
                //.MapsToBedrockBlock<BedrockBlocks.Comparator_On>();
        }
    }
}
