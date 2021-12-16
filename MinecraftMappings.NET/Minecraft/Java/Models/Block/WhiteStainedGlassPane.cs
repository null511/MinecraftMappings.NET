using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteStainedGlassPane : JavaBlockModel
    {
        public WhiteStainedGlassPane() : base("White Stained Glass Pane")
        {
            AddVersion("white_stained_glass_pane", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glass_pane")
                .AddTexture("pane", "block/white_stained_glass")
                .AddTexture("edge", "block/white_stained_glass_pane_top");
        }
    }
}
