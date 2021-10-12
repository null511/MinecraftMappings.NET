using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeetrootsStage1 : JavaBlockData
    {
        public BeetrootsStage1() : base("Beetroots, Stage 1")
        {
            AddVersion("beetroots_stage1")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage1>()
                .MapsToBedrockBlock<BedrockBlocks.BeetrootsStage1>();
        }
    }
}
