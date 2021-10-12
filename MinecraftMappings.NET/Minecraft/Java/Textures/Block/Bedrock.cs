using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Bedrock : JavaBlockData
    {
        public Bedrock() : base("Bedrock")
        {
            AddVersion("bedrock")
                .MapsToBedrockBlock<BedrockBlocks.Bedrock>();
        }
    }
}
