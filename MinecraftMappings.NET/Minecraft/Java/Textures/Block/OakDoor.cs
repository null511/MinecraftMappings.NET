using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakDoor : JavaBlockTexture
    {
        public OakDoor() : base("Oak Door")
        {
            AddVersion("door")
                .WithMaxVersion("1.8")
                .WithDefaultModel<Java.Models.Block.OakDoor>();

            AddVersion(1, "oak_door")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.OakDoor>();
        }
    }
}
