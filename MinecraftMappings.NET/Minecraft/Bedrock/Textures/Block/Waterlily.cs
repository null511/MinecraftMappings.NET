using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class Waterlily : BedrockBlockTexture
    {
        public Waterlily() : base("Waterlily")
        {
            AddVersion("waterlily")
                .MapsToJavaBlock<Java.Textures.Block.LilyPad>();
        }
    }
}
