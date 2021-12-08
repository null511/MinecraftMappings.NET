using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AmethystCluster : JavaBlockTexture
    {
        public AmethystCluster() : base("Amethyst Cluster")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "amethyst_cluster")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.AmethystCluster>();
                //.MapsToBedrockBlock<BedrockBlocks.AmethystCluster>();
        }
    }
}
