using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownStainedGlassPaneSide : JavaBlockModel
    {
        public BrownStainedGlassPaneSide() : base("Brown Stained Glass Pane Side")
        {
            AddVersion("brown_stained_glass_pane_side", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glass_pane_side")
                .AddTexture("pane", "block/brown_stained_glass")
                .AddTexture("edge", "block/brown_stained_glass_pane_top");
        }
    }
}
