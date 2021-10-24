using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class StrippedOakLog : JavaBlockTexture
    {
        public StrippedOakLog() : base("Stripped Oak Log")
        {
            AddVersion("stripped_oak_log")
                .WithDefaultModel<Java.Models.Block.StrippedOakLog>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.StrippedOakLog>();
        }
    }
}
