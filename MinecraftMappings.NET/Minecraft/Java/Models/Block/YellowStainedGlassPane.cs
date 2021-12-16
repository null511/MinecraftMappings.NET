using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class YellowStainedGlassPane : JavaBlockModel
    {
        public YellowStainedGlassPane() : base("Yellow Stained Glass Pane")
        {
            AddVersion("yellow_stained_glass_pane", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glass_pane")
                .AddTexture("pane", "block/yellow_stained_glass")
                .AddTexture("edge", "block/yellow_stained_glass_pane_top");
        }
    }
}
