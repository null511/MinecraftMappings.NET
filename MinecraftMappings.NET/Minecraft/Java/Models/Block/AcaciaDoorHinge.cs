using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaDoorHinge : JavaBlockModel
    {
        public AcaciaDoorHinge() : base("Acacia Door, Hinge")
        {
            AddVersion("acacia_door_hinge", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_rh")
                .AddTexture("top", "block/acacia_door_top")
                .AddTexture("bottom", "block/acacia_door_bottom");
        }
    }
}
