using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MagentaWool : JavaBlockTexture
    {
        public MagentaWool() : base("Magenta Wool")
        {
            AddVersion("magenta_wool");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WoolColoredMagenta>();
        }
    }
}
