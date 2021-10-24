using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class KelpTop : BedrockBlockTexture
    {
        public KelpTop() : base("Kelp Top")
        {
            AddVersion("kelp_top")
                .MapsToJavaBlock<Java.Textures.Block.Kelp>();
        }
    }
}
