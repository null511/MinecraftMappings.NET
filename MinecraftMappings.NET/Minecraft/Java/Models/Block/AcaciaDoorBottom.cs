using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaDoorBottom : JavaBlockModel
    {
        public AcaciaDoorBottom() : base("Acacia Door, Bottom")
        {
            AddVersion("acacia_door_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_bottom")
                .AddTexture("top", "block/acacia_door_top")
                .AddTexture("bottom", "block/acacia_door_bottom");
        }
    }
}
