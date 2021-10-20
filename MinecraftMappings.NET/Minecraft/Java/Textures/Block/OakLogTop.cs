using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Bedrock.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakLogTop : JavaBlockTexture
    {
        public OakLogTop() : base("Oak Log, Top")
        {
            AddVersion("oak_log_top")
                .WithDefaultModel<Java.Models.Block.OakLog>()
                .MapsToBedrockBlock<LogOakTop>();
        }
    }
}
