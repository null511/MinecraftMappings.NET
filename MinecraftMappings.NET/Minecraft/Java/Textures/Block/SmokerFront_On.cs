using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmokerFront_On : JavaBlockTexture
    {
        public SmokerFront_On() : base("Smoker Front, On")
        {
            AddVersion("smoker_front_on")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.Smoker>();
                //.MapsToBedrockBlock<BedrockBlocks.SmokerFront_On>();
        }
    }
}
