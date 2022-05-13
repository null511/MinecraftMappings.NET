using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SeaPickle : JavaBlockTexture
    {
        public SeaPickle() : base("Sea Pickle")
        {
            AddVersion("sea_pickle")
                .WithDefaultModel<Java.Models.Block.SeaPickle>();
                //.MapsToBedrockBlock<BedrockBlocks.SeaPickle>();
        }
    }
}
