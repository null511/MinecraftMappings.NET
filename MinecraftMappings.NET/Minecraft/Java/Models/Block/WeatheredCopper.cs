using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WeatheredCopper : JavaBlockModel
    {
        public WeatheredCopper() : base("Weathered Copper")
        {
            AddVersion("weathered_copper", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/weathered_copper");
        }
    }
}
