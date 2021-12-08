using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class GoldBlock : JavaBlockTexture
    {
        public GoldBlock() : base("Gold Block")
        {
            AddVersion("gold_block");
                //.WithDefaultModel<Java.Models.Block.GoldBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.GoldBlock>();
        }
    }
}
