using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaPlanks : JavaBlockTexture
    {
        public AcaciaPlanks() : base("Acacia Planks")
        {
            AddVersion("acacia_planks")
                .WithDefaultModel<Java.Models.Block.AcaciaPlanks>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PlanksAcacia>();
        }
    }
}
