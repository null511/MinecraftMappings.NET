using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedOakLogTop : JavaBlockTexture
    {
        public StrippedOakLogTop() : base("Stripped Oak Log Top")
        {
            AddVersion("stripped_oak_log_top")
                .WithDefaultModel<Java.Models.Block.StrippedOakLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedOakLogTop>();
        }
    }
}
