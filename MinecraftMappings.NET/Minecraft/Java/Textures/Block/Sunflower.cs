using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Sunflower : JavaBlockTexture
    {
        public Sunflower() : base("Sunflower")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sunflower")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.Sunflower>();
        }
    }
}
