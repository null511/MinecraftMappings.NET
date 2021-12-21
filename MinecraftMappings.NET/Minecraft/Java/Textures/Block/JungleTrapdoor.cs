using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JungleTrapdoor : JavaBlockTexture
    {
        public JungleTrapdoor() : base("Jungle Trapdoor")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("jungle_trapdoor")
                .WithDefaultModel<Java.Models.Block.JungleTrapdoorTop>();
        }
    }
}
