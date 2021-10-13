using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
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
