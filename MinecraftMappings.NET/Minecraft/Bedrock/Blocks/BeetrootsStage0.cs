using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeetrootsStage0 : BedrockBlockTexture
    {
        public BeetrootsStage0() : base("Beetroots, Stage 0")
        {
            AddVersion("beetroots_stage0")
                .MapsToJavaBlock<Java.Textures.Block.BeetrootsStage0>();
        }
    }
}
