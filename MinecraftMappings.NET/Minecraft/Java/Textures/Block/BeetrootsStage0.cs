using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeetrootsStage0 : JavaBlockTexture
    {
        public BeetrootsStage0() : base("Beetroots, Stage 0")
        {
            AddVersion("beetroots_stage0")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage0>()
                .MapsToBedrockBlock<BedrockBlocks.BeetrootsStage0>();
        }
    }
}
