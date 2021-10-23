using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class HayBlockTop : BedrockBlockTexture
    {
        public HayBlockTop() : base("Hay Block Top")
        {
            AddVersion("hay_block_top")
                .MapsToJavaBlock<Java.Textures.Block.HayBlockTop>();
        }
    }
}
