using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchLogTop : JavaBlockTexture
    {
        public BirchLogTop() : base("Birch Log, Top")
        {
            AddVersion("birch_log_top")
                //.WithDefaultModel<Java.Models.Block.BirchLog>()
                .MapsToBedrockBlock<BedrockBlocks.LogBirchTop>();
        }
    }
}
