using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownMushroomBlock : JavaBlockTexture
    {
        public BrownMushroomBlock() : base("Brown Mushroom Block")
        {
            AddVersion("brown_mushroom_block")
                .MapsToBedrockBlock<BedrockBlocks.MushroomBlockSkinBrown>();
        }
    }
}
