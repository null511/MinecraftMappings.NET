using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueWool : JavaBlockTexture
    {
        public BlueWool() : base("Blue Wool")
        {
            AddVersion("blue_wool")
                .MapsToBedrockBlock<BedrockBlocks.WoolColoredBlue>();
        }
    }
}
