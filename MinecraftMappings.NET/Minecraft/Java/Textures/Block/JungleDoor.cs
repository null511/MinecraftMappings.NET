using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JungleDoor : JavaBlockTexture
    {
        public JungleDoor() : base("Jungle Door")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("jungle_door")
                .WithDefaultModel<Java.Models.Block.JungleDoor>();
        }
    }
}
