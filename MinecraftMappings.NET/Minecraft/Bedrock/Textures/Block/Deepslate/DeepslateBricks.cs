using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class DeepslateBricks : BedrockBlockTexture
    {
        public DeepslateBricks() : base("Deepslate Bricks")
        {
            AddVersion("deepslate_bricks")
                .MapsToJavaBlock<Java.Textures.Block.DeepslateBricks>();
        }
    }
}
