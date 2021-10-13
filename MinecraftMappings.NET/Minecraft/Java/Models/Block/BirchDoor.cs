using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BirchDoor : JavaBlockModel
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
