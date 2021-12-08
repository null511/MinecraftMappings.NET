using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BuddingAmethyst : JavaBlockTexture
    {
        public BuddingAmethyst() : base("Budding Amethyst")
        {
            AddVersion(7, "budding_amethyst")
                .WithMinVersion("1.17");
                //.WithDefaultModel<Java.Models.Block.BuddingAmethyst>()
                //.MapsToBedrockBlock<BedrockBlocks.AmethystCluster>();
        }
    }
}
