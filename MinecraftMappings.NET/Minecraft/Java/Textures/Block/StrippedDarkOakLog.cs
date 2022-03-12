using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedDarkOakLog : JavaBlockTexture
    {
        public StrippedDarkOakLog() : base("Stripped Dark Oak Log")
        {
            AddVersion("stripped_dark_oak_log")
                .WithDefaultModel<Java.Models.Block.StrippedDarkOakLog>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedDarkOakLog>();
        }
    }
}
