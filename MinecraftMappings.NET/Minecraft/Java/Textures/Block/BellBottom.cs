using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BellBottom : JavaBlockTexture
    {
        public BellBottom() : base("Bell Bottom")
        {
            AddVersion("bell_bottom")
                .MapsToBedrockBlock<BedrockBlocks.BellBottom>();
        }
    }
}
