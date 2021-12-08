using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FloweringAzaleaSide : JavaBlockTexture
    {
        public FloweringAzaleaSide() : base("Flowering Azalea Side")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "flowering_azalea_side")
                .WithMinVersion("1.17");
                //.WithDefaultModel<Java.Models.Block.FloweringAzalea>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LeavesAzaleaFloweringSide>();
        }
    }
}
