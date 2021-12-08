using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchDoor : JavaBlockTexture
    {
        public BirchDoor() : base("Birch Door")
        {
            AddVersion(1, "birch_door")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.BirchDoor>();
        }
    }
}
