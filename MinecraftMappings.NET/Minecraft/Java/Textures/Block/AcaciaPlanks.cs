using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaPlanks : JavaBlockTexture
    {
        public AcaciaPlanks() : base("Acacia Planks")
        {
            AddVersion("acacia_planks")
                .WithDefaultModel<Java.Models.Block.AcaciaPlanks>()
                .MapsToBedrockBlock<BedrockBlocks.PlanksAcacia>();
        }
    }
}
