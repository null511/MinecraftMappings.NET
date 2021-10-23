using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class StrippedAcaciaLogTop : BedrockBlockTexture
    {
        public StrippedAcaciaLogTop() : base("Stripped Acacia Log Top")
        {
            AddVersion("stripped_acacia_log_top")
                .MapsToJavaBlock<Java.Textures.Block.StrippedAcaciaLogTop>();
        }
    }
}
