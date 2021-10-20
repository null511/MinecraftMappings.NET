using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class BeetrootsStage2 : BedrockBlockTexture
    {
        public BeetrootsStage2() : base("Beetroots, Stage 2")
        {
            AddVersion("beetroots_stage2")
                .MapsToJavaBlock<Java.Textures.Block.BeetrootsStage2>();
        }
    }
}
