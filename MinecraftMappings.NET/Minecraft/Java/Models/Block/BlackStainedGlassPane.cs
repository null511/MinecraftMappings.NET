using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackStainedGlassPane : JavaBlockModel
    {
        public BlackStainedGlassPane() : base("Black Stained Glass Pane")
        {
            AddVersion("black_stained_glass_pane", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glass_pane")
                .AddTexture("pane", "block/black_stained_glass")
                .AddTexture("edge", "block/black_stained_glass_pane_top");
        }
    }
}
