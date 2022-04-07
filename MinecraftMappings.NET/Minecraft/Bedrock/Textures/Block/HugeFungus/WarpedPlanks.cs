using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class WarpedPlanks : BedrockBlockTexture
    {
        public WarpedPlanks() : base("Warped Planks")
        {
            AddVersion("warped_planks")
                .MapsToJavaBlock<Java.Textures.Block.WarpedPlanks>();
        }
    }
}
