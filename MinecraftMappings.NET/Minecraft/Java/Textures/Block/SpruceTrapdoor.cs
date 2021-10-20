using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceTrapdoor : JavaBlockTexture
    {
        public SpruceTrapdoor() : base("Spruce Trapdoor")
        {
            AddVersion("spruce_trapdoor")
                .WithDefaultModel<Java.Models.Block.SpruceTrapdoorTop>();
                //.MapsToBedrockBlock<BedrockBlocks.SpruceTrapdoor>();
        }
    }
}
