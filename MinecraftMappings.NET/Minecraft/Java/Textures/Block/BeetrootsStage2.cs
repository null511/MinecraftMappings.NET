using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeetrootsStage2 : JavaBlockData
    {
        public BeetrootsStage2() : base("Beetroots, Stage 2")
        {
            AddVersion("beetroots_stage2")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage2>()
                .MapsToBedrockBlock<BedrockBlocks.BeetrootsStage2>();
        }
    }
}
