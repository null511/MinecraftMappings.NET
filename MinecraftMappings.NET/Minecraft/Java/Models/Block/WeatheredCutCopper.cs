using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WeatheredCutCopper : JavaBlockModel
    {
        public WeatheredCutCopper() : base("Weathered Cut Copper")
        {
            AddVersion("weathered_cut_copper", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/weathered_cut_copper");
        }
    }
}
