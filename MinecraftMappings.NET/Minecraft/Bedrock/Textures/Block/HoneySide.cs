using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class HoneySide : BedrockBlockTexture
    {
        public HoneySide() : base("Honey Side")
        {
            AddVersion("honey_side")
                .MapsToJavaBlock<Java.Textures.Block.HoneyBlockSide>();
        }
    }
}
