using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmokerSide : JavaBlockTexture
    {
        public SmokerSide() : base("Smoker Side")
        {
            AddVersion("smoker_side")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.Smoker>();
                //.MapsToBedrockBlock<BedrockBlocks.Smoker>();
        }
    }
}
