using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedSpruceLog : JavaBlockTexture
    {
        public StrippedSpruceLog() : base("Stripped Spruce Log")
        {
            AddVersion("stripped_spruce_log");
                //.WithDefaultModel<Java.Models.Block.StrippedSpruceLog>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedSpruceLog>();
        }
    }
}
