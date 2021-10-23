using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakLog : JavaBlockTexture
    {
        public DarkOakLog() : base("Dark Oak Log")
        {
            AddVersion("dark_oak_log")
                .WithDefaultModel<Java.Models.Block.DarkOakLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LogBigOak>();
        }
    }
}
