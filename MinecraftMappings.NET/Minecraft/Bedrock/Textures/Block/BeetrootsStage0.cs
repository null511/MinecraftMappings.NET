using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BeetrootsStage0 : BedrockBlockTexture
    {
        public BeetrootsStage0() : base("Beetroots, Stage 0")
        {
            AddVersion("beetroots_stage0")
                .MapsToJavaBlock<Java.Textures.Block.Beetroots_Stage0>();
        }
    }
}
