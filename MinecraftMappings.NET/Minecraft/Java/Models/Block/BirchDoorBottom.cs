using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BirchDoorBottom : JavaBlockModel
    {
        public BirchDoorBottom() : base("Birch Door, Bottom")
        {
            AddVersion("birch_door_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_bottom")
                .AddTexture("top", "block/birch_door_top")
                .AddTexture("bottom", "block/birch_door_bottom");
        }
    }
}
