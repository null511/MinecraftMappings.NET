using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class IronTrapdoor : JavaBlockTexture
    {
        public IronTrapdoor() : base("Iron Trapdoor")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("iron_trapdoor")
                .WithDefaultModel<Java.Models.Block.IronTrapdoorTop>();
        }
    }
}
