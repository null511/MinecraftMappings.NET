using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaPlanks : JavaBlockTexture
    {
        public AcaciaPlanks() : base("Acacia Planks")
        {
            AddVersion(1, "acacia_planks")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.AcaciaPlanks>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PlanksAcacia>();
        }
    }
}
