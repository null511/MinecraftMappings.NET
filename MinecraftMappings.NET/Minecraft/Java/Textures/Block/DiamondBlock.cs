using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DiamondBlock : JavaBlockTexture
    {
        public DiamondBlock() : base("Diamond Block")
        {
            AddVersion("diamond_block");
                //.WithDefaultModel<Java.Models.Block.DiamondBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DiamondBlock>();
        }
    }
}
