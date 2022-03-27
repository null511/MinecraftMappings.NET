using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CobbledDeepslateStairs : JavaBlockModel
    {
        public CobbledDeepslateStairs() : base("Cobbled Deepslate Stairs")
        {
            AddVersion("cobbled_deepslate_stairs", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stairs")
                .AddTexture("bottom", "block/cobbled_deepslate")
                .AddTexture("top", "block/cobbled_deepslate")
                .AddTexture("side", "block/cobbled_deepslate");
        }
    }
}
