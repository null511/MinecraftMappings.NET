using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RawCopperBlock : JavaBlockTexture
    {
        public RawCopperBlock() : base("Raw Copper Block")
        {
            AddVersion("raw_copper_block");
                //.WithDefaultModel<JavaBlockModel>(Java.Models.Block.RawCopperBlock)
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RawCopperBlock>();
        }
    }
}
