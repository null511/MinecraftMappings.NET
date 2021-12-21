using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedTrapdoor : JavaBlockTexture
    {
        public WarpedTrapdoor() : base("Warped Trapdoor")
        {
            AddVersion("warped_trapdoor")
                .WithDefaultModel<Java.Models.Block.WarpedTrapdoorTop>();
                //.MapsToBedrockBlock<BedrockBlocks.WarpedTrapdoor>();
        }
    }
}
