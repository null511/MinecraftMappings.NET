using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class DeepslateTiles : BedrockBlockTexture
    {
        public DeepslateTiles() : base("Deepslate Tiles")
        {
            AddVersion("deepslate_tiles")
                .MapsToJavaBlock<Java.Textures.Block.DeepslateTiles>();
        }
    }
}
