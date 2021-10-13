using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AmethystCluster : JavaBlockModel
    {
        public AmethystCluster() : base("Amethyst Cluster")
        {
            AddVersion("amethyst_cluster", "1.17")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/amethyst_cluster");
        }
    }
}
