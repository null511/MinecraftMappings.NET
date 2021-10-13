using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

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
