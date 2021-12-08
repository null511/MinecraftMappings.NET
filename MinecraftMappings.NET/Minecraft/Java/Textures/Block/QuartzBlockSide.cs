using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class QuartzBlockSide : JavaBlockTexture
    {
        public QuartzBlockSide() : base("Quartz Block Side")
        {
            AddVersion("quartz_block_side");
                //.WithDefaultModel<Java.Models.Block.QuartzBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.QuartzBlockSide>();
        }
    }
}
