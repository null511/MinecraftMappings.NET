using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaLogTop : JavaBlockTexture
    {
        public AcaciaLogTop() : base("Acacia Log, Top")
        {
            AddVersion("acacia_log_top")
                .WithDefaultModel<Java.Models.Block.AcaciaLog>()
                .MapsToBedrockBlock<BedrockBlocks.LogAcaciaTop>();
        }
    }
}
