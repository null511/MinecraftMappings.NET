using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueStainedGlassPaneSide : JavaBlockModel
    {
        public BlueStainedGlassPaneSide() : base("Blue Stained Glass Pane Side")
        {
            AddVersion("blue_stained_glass_pane_side", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glass_pane_side")
                .AddTexture("pane", "block/blue_stained_glass")
                .AddTexture("edge", "block/blue_stained_glass_pane_top");
        }
    }
}
