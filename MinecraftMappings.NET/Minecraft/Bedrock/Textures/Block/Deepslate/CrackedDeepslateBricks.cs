using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.Deepslate
{
    public class CrackedDeepslateBricks : BedrockBlockTexture
    {
        public CrackedDeepslateBricks() : base("Cracked Deepslate Bricks")
        {
            AddVersion("cracked_deepslate_bricks")
                .MapsToJavaBlock<Java.Textures.Block.CrackedDeepslateBricks>();
        }
    }
}
