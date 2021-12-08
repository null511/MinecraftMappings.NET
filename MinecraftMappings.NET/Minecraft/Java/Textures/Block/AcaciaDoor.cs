using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaDoor : JavaBlockTexture
    {
        public AcaciaDoor() : base("Acacia Door")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "acacia_door")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.AcaciaDoor>();
        }
    }
}
