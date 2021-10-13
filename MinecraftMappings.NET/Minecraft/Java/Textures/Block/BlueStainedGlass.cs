using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BlueStainedGlass : JavaBlockTexture
    {
        public BlueStainedGlass() : base("Blue Stained Glass")
        {
            AddVersion("blue_stained_glass")
                .MapsToBedrockBlock<BedrockBlocks.GlassBlue>();
        }
    }
}
