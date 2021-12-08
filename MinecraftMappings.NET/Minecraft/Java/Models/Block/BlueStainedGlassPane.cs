using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueStainedGlassPane : JavaBlockModel
    {
        public BlueStainedGlassPane() : base("Blue Stained Glass Pane")
        {
            AddVersion("blue_stained_glass_pane", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glass_pane")
                .AddTexture("pane", "block/blue_stained_glass")
                .AddTexture("edge", "block/blue_stained_glass_pane_top");
        }
    }
}
