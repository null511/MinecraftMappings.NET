using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchDoor : JavaBlockTexture
    {
        public BirchDoor() : base("Birch Door")
        {
            AddVersion("birch_door")
                .WithDefaultModel<Java.Models.Block.BirchDoor>();
        }
    }
}
