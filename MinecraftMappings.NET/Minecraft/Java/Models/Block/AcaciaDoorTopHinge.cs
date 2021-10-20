using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaDoorTopHinge : JavaBlockModel
    {
        public AcaciaDoorTopHinge() : base("Acacia Door, Top Hinge")
        {
            AddVersion("acacia_door_top_hinge", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top_rh")
                .AddTexture("top", "block/acacia_door_top")
                .AddTexture("bottom", "block/acacia_door_bottom");
        }
    }
}
