using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CyanStainedGlassPane : JavaBlockModel
    {
        public CyanStainedGlassPane() : base("Cyan Stained Glass Pane")
        {
            AddVersion("cyan_stained_glass_pane", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glass_pane")
                .AddTexture("pane", "block/cyan_stained_glass")
                .AddTexture("edge", "block/cyan_stained_glass_pane_top");
        }
    }
}
