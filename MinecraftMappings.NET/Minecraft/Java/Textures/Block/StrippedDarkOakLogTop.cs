using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedDarkOakLogTop : JavaBlockTexture
    {
        public StrippedDarkOakLogTop() : base("Stripped Dark Oak Log Top")
        {
            AddVersion("stripped_dark_oak_log_top")
                .WithDefaultModel<Java.Models.Block.StrippedDarkOakLog>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedDarkOakLogTop>();
        }
    }
}
