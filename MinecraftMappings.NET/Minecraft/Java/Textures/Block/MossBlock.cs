using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MossBlock : JavaBlockTexture
    {
        public MossBlock() : base("Moss Block")
        {
            AddVersion("moss_block");
                //.WithDefaultModel<Java.Models.Block.MossBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MossBlock>();
        }
    }
}
