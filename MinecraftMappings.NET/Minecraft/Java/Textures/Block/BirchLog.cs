using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchLog : JavaBlockTexture
    {
        public BirchLog() : base("Birch Log")
        {
            AddVersion("birch_log")
                //.WithDefaultModel<Java.Models.Block.BirchLog>()
                .MapsToBedrockBlock<BedrockBlocks.LogBirch>();
        }
    }
}
