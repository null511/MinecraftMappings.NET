using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RawIronBlock : JavaBlockTexture
    {
        public RawIronBlock() : base("Raw Iron Block")
        {
            AddVersion("raw_iron_block");
                //.WithDefaultModel<JavaBlockModel>(Java.Models.Block.RawIronBlock)
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RawIronBlock>();
        }
    }
}
