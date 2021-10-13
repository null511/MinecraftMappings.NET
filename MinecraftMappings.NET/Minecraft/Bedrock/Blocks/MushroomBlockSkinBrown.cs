using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Java.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class MushroomBlockSkinBrown : BedrockBlockTexture
    {
        public MushroomBlockSkinBrown() : base("Mushroom Block Skin Brown")
        {
            AddVersion("mushroom_block_skin_brown")
                .MapsToJavaBlock<BrownMushroomBlock>();
        }
    }
}
