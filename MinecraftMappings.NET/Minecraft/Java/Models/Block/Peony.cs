using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Peony : JavaBlockModel
    {
        public Peony() : base("Peony")
        {
            AddVersion("peony", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tall_cross")
                .AddTexture("cross_top", "block/peony_top")
                .AddTexture("cross_bottom", "block/peony_bottom");
        }
    }
}
