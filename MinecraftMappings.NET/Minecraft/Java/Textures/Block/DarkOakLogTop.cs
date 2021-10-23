using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakLogTop : JavaBlockTexture
    {
        public DarkOakLogTop() : base("Dark Oak Log Top")
        {
            AddVersion("dark_oak_log_top")
                .WithDefaultModel<Java.Models.Block.DarkOakLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LogBigOakTop>();
        }
    }
}
