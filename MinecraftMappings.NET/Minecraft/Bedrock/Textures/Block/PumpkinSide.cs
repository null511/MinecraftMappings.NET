using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class PumpkinSide : BedrockBlockTexture
    {
        public PumpkinSide() : base("Pumpkin Side")
        {
            AddVersion("pumpkin_side")
                .MapsToJavaBlock<Java.Textures.Block.PumpkinSide>();
        }
    }
}
