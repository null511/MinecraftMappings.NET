using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BellSide : JavaBlockTexture
    {
        public BellSide() : base("Bell Side")
        {
            AddVersion("bell_side")
                //.WithDefaultModel<Java.Models.Block.Bell>()
                .MapsToBedrockBlock<BedrockBlocks.BellSide>();
        }
    }
}
