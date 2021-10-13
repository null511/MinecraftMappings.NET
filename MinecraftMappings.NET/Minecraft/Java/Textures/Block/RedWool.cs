using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RedWool : JavaBlockTexture
    {
        public RedWool() : base("Blue Wool")
        {
            AddVersion("blue_wool")
                .WithMinVersion("1.6.1")
                .MapsToBedrockBlock<BedrockBlocks.WoolColoredBlue>();
        }
    }
}
