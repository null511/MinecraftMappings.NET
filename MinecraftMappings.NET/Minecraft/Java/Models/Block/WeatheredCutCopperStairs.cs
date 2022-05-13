using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WeatheredCutCopperStairs : JavaBlockModel
    {
        public WeatheredCutCopperStairs() : base("Weathered Cut Copper Stairs")
        {
            AddVersion("weathered_cut_copper_stairs", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stairs")
                .AddTexture("bottom", "block/weathered_cut_copper")
                .AddTexture("top", "block/weathered_cut_copper")
                .AddTexture("side", "block/weathered_cut_copper");
        }
    }
}
