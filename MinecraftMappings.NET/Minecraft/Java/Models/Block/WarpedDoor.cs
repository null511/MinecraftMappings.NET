using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedDoor : JavaBlockModel
    {
        public WarpedDoor() : base("Warped Door")
        {
            AddVersion("warped_door", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door")
                .AddTexture("top", "block/warped_door_top")
                .AddTexture("bottom", "block/warped_door_bottom");
        }
    }
}
