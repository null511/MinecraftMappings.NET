using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class OakDoor : JavaBlockTexture
    {
        public OakDoor() : base("Oak Door")
        {
            AddVersion("oak_door")
                .WithDefaultModel<Java.Models.Block.OakDoor>();
        }
    }
}
