using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Piston : JavaBlockModel
    {
        public Piston() : base("Piston")
        {
            AddVersion("piston", "1.3.1")
                .WithPath("models/block")
                .WithParent("block/template_piston")
                .AddTexture("platform", "block/piston_top")
                .AddTexture("bottom", "block/piston_bottom")
                .AddTexture("side", "block/piston_side");
        }
    }
}
