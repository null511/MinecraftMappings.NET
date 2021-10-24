using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OakDoorBottom : JavaBlockModel
    {
        public OakDoorBottom() : base("Oak Door, Bottom")
        {
            AddVersion("oak_door_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_bottom")
                .AddTexture("top", "block/oak_door_top")
                .AddTexture("bottom", "block/oak_door_bottom");
        }
    }
}
