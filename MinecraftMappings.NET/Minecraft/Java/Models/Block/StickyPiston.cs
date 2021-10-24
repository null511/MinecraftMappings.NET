using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StickyPiston : JavaBlockModel
    {
        public StickyPiston() : base("Sticky Piston")
        {
            AddVersion("sticky_piston", "1.3.1")
                .WithPath("models/block")
                .WithParent("block/template_piston")
                .AddTexture("platform", "block/piston_top_sticky")
                .AddTexture("bottom", "block/piston_bottom")
                .AddTexture("side", "block/piston_side");
        }
    }
}
