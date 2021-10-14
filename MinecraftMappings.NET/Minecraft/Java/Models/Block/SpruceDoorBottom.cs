using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SpruceDoorBottom : JavaBlockModel
    {
        public SpruceDoorBottom() : base("Spruce Door, Bottom")
        {
            AddVersion("spruce_door_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_bottom")
                .AddTexture("top", "block/spruce_door_top")
                .AddTexture("bottom", "block/spruce_door_bottom");
        }
    }
}
