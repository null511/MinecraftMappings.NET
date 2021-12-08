using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RawGoldBlock : JavaBlockTexture
    {
        public RawGoldBlock() : base("Raw Gold Block")
        {
            AddVersion("raw_gold_block");
                //.WithDefaultModel<JavaBlockModel>(Java.Models.Block.RawGoldBlock)
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RawGoldBlock>();
        }
    }
}
