using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaTrapdoor : JavaBlockTexture
    {
        public AcaciaTrapdoor() : base("Acacia Trapdoor")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(4, "acacia_trapdoor")
                .WithMinVersion("1.13")
                .WithDefaultModel<Java.Models.Block.AcaciaTrapdoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.AcaciaTrapdoor>();
        }
    }
}
