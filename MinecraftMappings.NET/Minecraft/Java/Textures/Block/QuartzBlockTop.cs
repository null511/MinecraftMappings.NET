using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class QuartzBlockTop : JavaBlockTexture
    {
        public QuartzBlockTop() : base("Quartz Block Top")
        {
            AddVersion("quartz_block_top");
                //.WithDefaultModel<Java.Models.Block.QuartzBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.QuartzBlockTop>();
        }
    }
}
