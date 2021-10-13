using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Bedrock : JavaBlockTexture
    {
        public Bedrock() : base("Bedrock")
        {
            AddVersion("bedrock")
                .WithDefaultModel<Java.Models.Block.Bedrock>()
                .MapsToBedrockBlock<BedrockBlocks.Bedrock>();
        }
    }
}
