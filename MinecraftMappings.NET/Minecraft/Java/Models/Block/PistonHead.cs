using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PistonHead : JavaBlockModel
    {
        public PistonHead() : base("Piston Head")
        {
            AddVersion("piston_head", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_piston_head")
                .AddTexture("platform", "block/piston_top")
                .AddTexture("side", "block/piston_side")
                .AddTexture("unsticky", "block/piston_top");
        }
    }
}
