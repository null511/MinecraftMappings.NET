using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceLog : JavaBlockTexture
    {
        public SpruceLog() : base("Spruce Log")
        {
            AddVersion("spruce_log")
                .WithDefaultModel<Java.Models.Block.SpruceLog>()
                .MapsToBedrockBlock<BedrockBlocks.LogSpruce>();
        }
    }
}
