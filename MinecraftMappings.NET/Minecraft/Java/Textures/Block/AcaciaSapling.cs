using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaSapling : JavaBlockTexture
    {
        public AcaciaSapling() : base("Acacia Sapling")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "acacia_sapling")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.AcaciaSapling>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SaplingAcacia>();
        }
    }
}
