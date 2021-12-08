using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChiseledQuartzBlock : JavaBlockTexture
    {
        public ChiseledQuartzBlock() : base("Chiseled Quartz Block")
        {
            AddVersion("chiseled_quartz_block");
                //.WithDefaultModel<Java.Models.Block.ChiseledQuartzBlock>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ChiseledQuartzBlock>();
        }
    }
}
