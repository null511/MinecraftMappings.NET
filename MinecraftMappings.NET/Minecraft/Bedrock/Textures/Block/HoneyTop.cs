using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class HoneyTop : BedrockBlockTexture
    {
        public HoneyTop() : base("Honey Top")
        {
            AddVersion("honey_top")
                .MapsToJavaBlock<Java.Textures.Block.HoneyBlockTop>();
        }
    }
}
