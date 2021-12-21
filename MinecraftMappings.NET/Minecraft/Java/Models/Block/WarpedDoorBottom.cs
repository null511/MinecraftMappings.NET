using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedDoorBottom : JavaBlockModel
    {
        public WarpedDoorBottom() : base("Warped Door Bottom")
        {
            AddVersion("warped_door_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_bottom")
                .AddTexture("top", "block/warped_door_top")
                .AddTexture("bottom", "block/warped_door_bottom");
        }
    }
}
