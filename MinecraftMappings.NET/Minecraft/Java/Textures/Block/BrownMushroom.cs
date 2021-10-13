using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownMushroom : JavaBlockTexture
    {
        public BrownMushroom() : base("Brown Mushroom")
        {
            AddVersion("brown_mushroom")
                .MapsToBedrockBlock<BedrockBlocks.MushroomBrown>();
        }
    }
}
