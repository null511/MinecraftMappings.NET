using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AmethystBlock : JavaBlockTexture
    {
        public AmethystBlock() : base("Amethyst Block")
        {
            AddVersion(7, "amethyst_block")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.AmethystBlock>();
                //.MapsToBedrockBlock<BedrockBlocks.AmethystCluster>();
        }
    }
}
