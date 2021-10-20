using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BrownMushroomBlock : JavaBlockTexture
    {
        public BrownMushroomBlock() : base("Brown Mushroom Block")
        {
            AddVersion("brown_mushroom_block")
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MushroomBlockSkinBrown>();
        }
    }
}
