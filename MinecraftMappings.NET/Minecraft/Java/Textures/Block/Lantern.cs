using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Lantern : JavaBlockTexture
    {
        public Lantern() : base("Lantern")
        {
            AddVersion("lantern")
                .WithDefaultModel<Java.Models.Block.Lantern>();
                //.MapsToBedrockBlock<BedrockBlocks.Lantern>();
        }
    }
}
