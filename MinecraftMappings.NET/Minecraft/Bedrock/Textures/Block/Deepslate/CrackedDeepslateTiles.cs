using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class CrackedDeepslateTiles : BedrockBlockTexture
    {
        public CrackedDeepslateTiles() : base("Cracked Deepslate Tiles")
        {
            AddVersion("cracked_deepslate_tiles")
                .MapsToJavaBlock<Java.Textures.Block.CrackedDeepslateTiles>();
        }
    }
}
