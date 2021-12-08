using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceTrapdoor : JavaBlockTexture
    {
        public SpruceTrapdoor() : base("Spruce Trapdoor")
        {
            AddVersion(4, "spruce_trapdoor")
                .WithMinVersion("1.13")
                .WithDefaultModel<Java.Models.Block.SpruceTrapdoorTop>();
                //.MapsToBedrockBlock<BedrockBlocks.SpruceTrapdoor>();
        }
    }
}
