using MinecraftMappings.Internal.Textures.Block;
using MinecraftMappings.Minecraft.Bedrock.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakLog : JavaBlockTexture
    {
        public OakLog() : base("Oak Log")
        {
            AddVersion("oak_log")
                .WithDefaultModel<Java.Models.Block.OakLog>()
                .MapsToBedrockBlock<LogOak>();
        }
    }
}
