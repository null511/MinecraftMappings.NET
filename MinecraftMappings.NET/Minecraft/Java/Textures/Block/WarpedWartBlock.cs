using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WarpedWartBlock : JavaBlockTexture
    {
        public WarpedWartBlock() : base("Warped Wart Block")
        {
            AddVersion("warped_wart_block");
                //.WithDefaultModel<Java.Models.Block.WarpedWartBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WarpedWartBlock>();
        }
    }
}
