using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedSpruceLogTop : JavaBlockTexture
    {
        public StrippedSpruceLogTop() : base("Stripped Spruce Log Top")
        {
            AddVersion("stripped_spruce_log_top");
                //.WithDefaultModel<Java.Models.Block.StrippedSpruceLog>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedSpruceLogTop>();
        }
    }
}
