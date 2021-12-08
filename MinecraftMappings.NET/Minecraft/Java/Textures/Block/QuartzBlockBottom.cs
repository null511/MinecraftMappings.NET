using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class QuartzBlockBottom : JavaBlockTexture
    {
        public QuartzBlockBottom() : base("Quartz Block Bottom")
        {
            AddVersion("quartz_block_bottom");
                //.WithDefaultModel<Java.Models.Block.QuartzBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.QuartzBlockBottom>();
        }
    }
}
