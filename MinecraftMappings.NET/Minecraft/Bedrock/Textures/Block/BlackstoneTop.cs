using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BlackstoneTop : BedrockBlockTexture
    {
        public BlackstoneTop() : base("Blackstone Top")
        {
            AddVersion("blackstone_top")
                .MapsToJavaBlock<Java.Textures.Block.BlackstoneTop>();
        }
    }
}
