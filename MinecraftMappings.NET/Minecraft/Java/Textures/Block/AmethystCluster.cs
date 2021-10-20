using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AmethystCluster : JavaBlockTexture
    {
        public AmethystCluster() : base("Amethyst Cluster")
        {
            AddVersion("amethyst_cluster")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.AmethystCluster>();
                //.MapsToBedrockBlock<BedrockBlocks.AmethystCluster>();
        }
    }
}
