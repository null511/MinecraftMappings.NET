using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class CrimsonLogSide : BedrockBlockTexture
    {
        public CrimsonLogSide() : base("Crimson Log Side")
        {
            AddVersion("crimson_log_side")
                .MapsToJavaBlock<Java.Textures.Block.CrimsonStem>();
        }
    }
}
