using MinecraftMappings.Internal.Textures.Block;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaSapling : JavaBlockTexture
    {
        public AcaciaSapling() : base("Acacia Sapling")
        {
            AddVersion("acacia_sapling")
                .WithDefaultModel<Java.Models.Block.AcaciaSapling>()
                .MapsToBedrockBlock<BedrockBlocks.SaplingAcacia>();
        }
    }
}
