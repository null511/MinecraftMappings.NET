using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmokerFront : JavaBlockTexture
    {
        public SmokerFront() : base("Smoker Front")
        {
            AddVersion("smoker_front")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.Smoker>();
                //.MapsToBedrockBlock<BedrockBlocks.Smoker>();
        }
    }
}
