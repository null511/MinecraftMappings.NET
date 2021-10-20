using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmokerTop : JavaBlockTexture
    {
        public SmokerTop() : base("Smoker Top")
        {
            AddVersion("smoker_top")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.Smoker>();
                //.MapsToBedrockBlock<BedrockBlocks.Smoker>();
        }
    }
}
