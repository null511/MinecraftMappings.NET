using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaSapling : JavaBlockData
    {
        public AcaciaSapling() : base("Acacia Sapling")
        {
            AddVersion("acacia_sapling")
                .WithDefaultModel<Java.Models.Block.AcaciaSapling>()
                .MapsToBedrockBlock<BedrockBlocks.SaplingAcacia>();
        }
    }
}
