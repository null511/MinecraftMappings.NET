using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PistonHeadSticky : JavaBlockModel
    {
        public PistonHeadSticky() : base("Piston Head, Sticky")
        {
            AddVersion("piston_head_sticky", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_piston_head")
                .AddTexture("platform", "block/piston_top_sticky")
                .AddTexture("side", "block/piston_side")
                .AddTexture("unsticky", "block/piston_top");
        }
    }
}
