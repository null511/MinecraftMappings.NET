using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeetrootsStage2 : BedrockBlockData
    {
        public BeetrootsStage2() : base("Beetroots, Stage 2")
        {
            AddVersion("beetroots_stage2")
                .MapsToJavaBlock<Java.Textures.Block.BeetrootsStage2>();
        }
    }
}
