using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaDoorBottomHinge : JavaBlockModel
    {
        public AcaciaDoorBottomHinge() : base("Acacia Door, Bottom Hinge")
        {
            AddVersion("acacia_door_bottom_hinge", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_bottom_rh")
                .AddTexture("top", "block/acacia_door_top")
                .AddTexture("bottom", "block/acacia_door_bottom");
        }
    }
}
