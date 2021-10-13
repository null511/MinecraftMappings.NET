using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaLog : JavaBlockTexture
    {
        public AcaciaLog() : base("Acacia Log")
        {
            AddVersion("acacia_log")
                .WithDefaultModel<Java.Models.Block.AcaciaLog>()
                .MapsToBedrockBlock<BedrockBlocks.LogAcacia>();
        }
    }
}
