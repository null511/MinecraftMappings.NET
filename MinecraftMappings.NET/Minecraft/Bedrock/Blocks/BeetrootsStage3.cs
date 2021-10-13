using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class BeetrootsStage3 : BedrockBlockTexture
    {
        public BeetrootsStage3() : base("Beetroots, Stage 3")
        {
            AddVersion("beetroots_stage3")
                .MapsToJavaBlock<Java.Textures.Block.BeetrootsStage3>();
        }
    }
}
