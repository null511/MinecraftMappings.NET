using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BirchDoor : JavaBlockData
    {
        public BirchDoor() : base("Birch Door")
        {
            AddVersion("birch_door")
                .WithDefaultModel<Java.Models.Block.BirchDoor>();
        }
    }
}
