using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedDoorTopHinge : JavaBlockModel
    {
        public WarpedDoorTopHinge() : base("Warped Door Top, Hinge")
        {
            AddVersion("warped_door_top_hinge", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/door_top_rh")
                .AddTexture("top", "block/warped_door_top")
                .AddTexture("bottom", "block/warped_door_bottom");
        }
    }
}
