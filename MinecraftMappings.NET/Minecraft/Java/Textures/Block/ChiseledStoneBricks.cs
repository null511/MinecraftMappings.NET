using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChiseledStoneBricks : JavaBlockTexture
    {
        public ChiseledStoneBricks() : base("Chiseled Stone Bricks")
        {
            AddVersion("chiseled_stone_bricks");
                //.WithDefaultModel<Java.Models.Block.ChiseledStoneBricks>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChiseledStoneBricks>();
        }
    }
}
