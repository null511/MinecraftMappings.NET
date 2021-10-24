using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class LoomTop : BedrockBlockTexture
    {
        public LoomTop() : base("Loom Top")
        {
            AddVersion("loom_top")
                .MapsToJavaBlock<Java.Textures.Block.LoomTop>();
        }
    }
}
