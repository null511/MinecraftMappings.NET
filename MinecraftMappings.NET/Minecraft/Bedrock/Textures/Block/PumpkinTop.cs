using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class PumpkinTop : BedrockBlockTexture
    {
        public PumpkinTop() : base("Pumpkin Top")
        {
            AddVersion("pumpkin_top")
                .MapsToJavaBlock<Java.Textures.Block.PumpkinTop>();
        }
    }
}
