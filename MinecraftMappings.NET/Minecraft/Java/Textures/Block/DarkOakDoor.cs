using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DarkOakDoor : JavaBlockTexture
    {
        public DarkOakDoor() : base("Dark Oak Door")
        {
            AddVersion(1, "dark_oak_door")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.DarkOakDoor>();
        }
    }
}
