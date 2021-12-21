using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class IronDoorBottom : JavaBlockModel
    {
        public IronDoorBottom() : base("Iron Door Bottom")
        {
            AddVersion("iron_door_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_bottom")
                .AddTexture("top", "block/iron_door_top")
                .AddTexture("bottom", "block/iron_door_bottom");
        }
    }
}
