using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Fern : JavaBlockTexture
    {
        public Fern() : base("Fern")
        {
            AddVersion("fern")
                .WithMinVersion("1.0.0")
                .WithDefaultModel<Java.Models.Block.Fern>();
                //.MapsToBedrockBlock<BedrockBlocks.Fern>();
        }
    }
}
