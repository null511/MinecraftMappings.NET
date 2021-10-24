using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class StrippedOakLogTop : BedrockBlockTexture
    {
        public StrippedOakLogTop() : base("Stripped Oak Log Top")
        {
            AddVersion("stripped_oak_log_top")
                .MapsToJavaBlock<Java.Textures.Block.StrippedOakLogTop>();
        }
    }
}
