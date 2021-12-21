using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CrimsonDoorBottom : JavaBlockModel
    {
        public CrimsonDoorBottom() : base("Crimson Door, Bottom")
        {
            AddVersion("crimson_door_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_bottom")
                .AddTexture("top", "block/crimson_door_top")
                .AddTexture("bottom", "block/crimson_door_bottom");
        }
    }
}
