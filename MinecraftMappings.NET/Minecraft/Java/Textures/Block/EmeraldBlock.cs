using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class EmeraldBlock : JavaBlockTexture
    {
        public EmeraldBlock() : base("Emerald Block")
        {
            AddVersion("emerald_block");
                //.WithDefaultModel<Java.Models.Block.EmeraldBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.EmeraldBlock>();
        }
    }
}
