using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Blackstone : JavaBlockTexture
    {
        public Blackstone() : base("Blackstone")
        {
            AddVersion("blackstone")
                .MapsToBedrockBlock<BedrockBlocks.Blackstone>();
        }
    }
}
