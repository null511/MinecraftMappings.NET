using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DarkOakDoor : JavaBlockModel
    {
        public DarkOakDoor() : base("Dark Oak Door")
        {
            AddVersion("dark_oak_door", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door")
                .AddTexture("top", "block/dark_oak_door_top")
                .AddTexture("bottom", "block/dark_oak_door_bottom");
        }
    }
}
