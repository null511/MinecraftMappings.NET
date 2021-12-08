using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class IronDoor : JavaBlockTexture
    {
        public IronDoor() : base("Iron Door")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("iron_door");
                //.WithDefaultModel<Java.Models.Block.IronDoor>();
        }
    }
}
