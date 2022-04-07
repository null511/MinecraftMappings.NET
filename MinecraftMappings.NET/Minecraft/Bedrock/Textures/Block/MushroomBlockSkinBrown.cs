using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class MushroomBlockSkinBrown : BedrockBlockTexture
    {
        public MushroomBlockSkinBrown() : base("Mushroom Block Skin Brown")
        {
            AddVersion("mushroom_block_skin_brown")
                .MapsToJavaBlock<Java.Textures.Block.BrownMushroomBlock>();
        }
    }
}
