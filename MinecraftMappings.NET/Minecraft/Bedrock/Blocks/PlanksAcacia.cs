using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class PlanksAcacia : BedrockBlockTexture
    {
        public PlanksAcacia() : base("Planks Acacia")
        {
            AddVersion("planks_acacia")
                .MapsToJavaBlock<Java.Textures.Block.AcaciaPlanks>();
        }
    }
}
