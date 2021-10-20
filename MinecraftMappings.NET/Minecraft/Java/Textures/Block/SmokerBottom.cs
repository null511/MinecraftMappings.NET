using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmokerBottom : JavaBlockTexture
    {
        public SmokerBottom() : base("Smoker Bottom")
        {
            AddVersion("smoker_bottom")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.Smoker>();
                //.MapsToBedrockBlock<BedrockBlocks.Smoker>();
        }
    }
}
