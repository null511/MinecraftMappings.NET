using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownStainedGlassPane : JavaBlockModel
    {
        public BrownStainedGlassPane() : base("Brown Stained Glass Pane")
        {
            AddVersion("brown_stained_glass_pane", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glass_pane")
                .AddTexture("pane", "block/brown_stained_glass")
                .AddTexture("edge", "block/brown_stained_glass_pane_top");
        }
    }
}
