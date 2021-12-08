using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SeaLantern : JavaBlockTexture
    {
        public SeaLantern() : base("Sea Lantern")
        {
            AddVersion("sea_lantern")
                .WithDefaultModel<Java.Models.Block.SeaLantern>();
                //.MapsToBedrockBlock<BedrockBlocks.SeaLantern>();
        }
    }
}
