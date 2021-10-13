using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BeetrootsStage3 : JavaBlockTexture
    {
        public BeetrootsStage3() : base("Beetroots, Stage 3")
        {
            AddVersion("beetroots_stage3")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage3>()
                .MapsToBedrockBlock<BedrockBlocks.BeetrootsStage3>();
        }
    }
}
