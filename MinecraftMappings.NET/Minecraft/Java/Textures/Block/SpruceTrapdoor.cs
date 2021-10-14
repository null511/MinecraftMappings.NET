using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

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
