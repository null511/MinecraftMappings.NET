using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MushroomBlockInside : JavaBlockTexture
    {
        public MushroomBlockInside() : base("Mushroom Block Inside")
        {
            AddVersion("mushroom_block_inside");
                //.WithDefaultModel<Java.Models.Block.MushroomBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MushroomBlockInside>();
        }
    }
}
