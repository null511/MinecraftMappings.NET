using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeetrootsStage1 : BedrockBlockData
    {
        public BeetrootsStage1() : base("Beetroots, Stage 1")
        {
            AddVersion("beetroots_stage1")
                .MapsToJavaBlock<Java.Textures.Block.BeetrootsStage1>();
        }
    }
}
