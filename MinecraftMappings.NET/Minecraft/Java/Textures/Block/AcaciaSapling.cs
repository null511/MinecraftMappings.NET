using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaSapling : JavaBlockTexture
    {
        public AcaciaSapling() : base("Acacia Sapling")
        {
            AddVersion("acacia_sapling")
                .WithDefaultModel<Java.Models.Block.AcaciaSapling>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SaplingAcacia>();
        }
    }
}
