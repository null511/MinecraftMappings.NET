using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SpruceLogTop : JavaBlockTexture
    {
        public SpruceLogTop() : base("Spruce Log, Top")
        {
            AddVersion("spruce_log_top")
                .WithDefaultModel<Java.Models.Block.SpruceLog>()
                .MapsToBedrockBlock<BedrockBlocks.LogSpruceTop>();
        }
    }
}
