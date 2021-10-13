using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueIce : JavaBlockTexture
    {
        public BlueIce() : base("Blue Ice")
        {
            AddVersion("blue_ice")
                .MapsToBedrockBlock<BedrockBlocks.BlueIce>();
        }
    }
}
