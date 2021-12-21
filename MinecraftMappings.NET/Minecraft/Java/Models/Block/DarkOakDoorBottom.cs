using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DarkOakDoorBottom : JavaBlockModel
    {
        public DarkOakDoorBottom() : base("Dark Oak Door Bottom")
        {
            AddVersion("dark_oak_door_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_bottom")
                .AddTexture("top", "block/dark_oak_door_top")
                .AddTexture("bottom", "block/dark_oak_door_bottom");
        }
    }
}
