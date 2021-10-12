using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Rail : JavaBlockData
    {
        public Rail() : base("Rail")
        {
            AddVersion("rail")
                .WithDefaultModel<Java.Models.Block.Rail>()
                .MapsToBedrockBlock<BedrockBlocks.BlueIce>();
        }
    }
}
