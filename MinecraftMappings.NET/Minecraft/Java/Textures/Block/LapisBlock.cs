using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LapisBlock : JavaBlockTexture
    {
        public LapisBlock() : base("Lapis Block")
        {
            AddVersion("lapis_block");
                //.WithDefaultModel<Java.Models.Block.LapisBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LapisBlock>();
        }
    }
}
