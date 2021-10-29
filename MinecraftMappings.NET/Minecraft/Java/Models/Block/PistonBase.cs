using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PistonBase : JavaBlockModel
    {
        public PistonBase() : base("Piston Base")
        {
            AddVersion("piston_base", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/piston_extended")
                .AddTexture("bottom", "block/piston_bottom")
                .AddTexture("side", "block/piston_side")
                .AddTexture("inside", "block/piston_inner");
        }
    }
}
