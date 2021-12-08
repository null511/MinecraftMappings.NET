using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChiseledQuartzBlockTop : JavaBlockTexture
    {
        public ChiseledQuartzBlockTop() : base("Chiseled Quartz Block Top")
        {
            AddVersion("chiseled_quartz_block_top");
                //.WithDefaultModel<Java.Models.Block.ChiseledQuartzBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChiseledQuartzBlockTop>();
        }
    }
}
