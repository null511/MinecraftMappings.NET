using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackStainedGlassPaneSide : JavaBlockModel
    {
        public BlackStainedGlassPaneSide() : base("Black Stained Glass Pane Side")
        {
            AddVersion("black_stained_glass_pane_side", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glass_pane_side")
                .AddTexture("pane", "block/black_stained_glass")
                .AddTexture("edge", "block/black_stained_glass_pane_top");
        }
    }
}
