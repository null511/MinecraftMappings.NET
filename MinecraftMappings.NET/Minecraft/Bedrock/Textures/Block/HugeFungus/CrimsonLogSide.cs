using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class CrimsonLogSide : BedrockBlockTexture
    {
        public CrimsonLogSide() : base("Crimson Log Side")
        {
            FrameCount = 5;

            AddVersion("crimson_log_side")
                .MapsToJavaBlock<Java.Textures.Block.CrimsonStem>();
        }
    }
}
