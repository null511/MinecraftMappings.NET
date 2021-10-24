using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CobblestoneMossy : BedrockBlockTexture
    {
        public CobblestoneMossy() : base("Cobblestone, Mossy")
        {
            AddVersion("cobblestone")
                .MapsToJavaBlock<Java.Textures.Block.MossyCobblestone>();
        }
    }
}
