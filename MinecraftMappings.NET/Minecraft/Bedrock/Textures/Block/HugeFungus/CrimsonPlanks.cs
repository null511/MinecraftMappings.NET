using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block.HugeFungus
{
    public class CrimsonPlanks : BedrockBlockTexture
    {
        public CrimsonPlanks() : base("Crimson Planks")
        {
            AddVersion("crimson_planks")
                .MapsToJavaBlock<Java.Textures.Block.CrimsonPlanks>();
        }
    }
}
