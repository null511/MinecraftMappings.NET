using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BirchDoor : JavaModelData
    {
        public BirchDoor() : base("Birch Door")
        {
            AddVersion("birch_door", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door")
                .AddTexture("top", "block/birch_door_top")
                .AddTexture("bottom", "block/birch_door_bottom");
        }
    }
}
