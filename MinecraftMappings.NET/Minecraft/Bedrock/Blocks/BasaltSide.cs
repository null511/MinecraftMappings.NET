using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BasaltSide : BedrockBlockTexture
    {
        public BasaltSide() : base("Basalt Side")
        {
            AddVersion("basalt_side")
                .MapsToJavaBlock<Java.Textures.Block.BasaltSide>();
        }
    }
}
