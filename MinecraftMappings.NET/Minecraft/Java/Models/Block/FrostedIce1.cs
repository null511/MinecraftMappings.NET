using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FrostedIce1 : JavaBlockModel
    {
        public FrostedIce1() : base("Frosted Ice 1")
        {
            AddVersion("frosted_ice_1", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/frosted_ice_1");
        }
    }
}
