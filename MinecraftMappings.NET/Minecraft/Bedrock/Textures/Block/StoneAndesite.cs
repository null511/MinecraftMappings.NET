using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class StoneAndesite : BedrockBlockTexture
    {
        public StoneAndesite() : base("Stone Andesite")
        {
            AddVersion("stone_andesite")
                .MapsToJavaBlock<Java.Textures.Block.Andesite>();
        }
    }
}
