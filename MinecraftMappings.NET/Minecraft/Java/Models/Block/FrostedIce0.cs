using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FrostedIce0 : JavaBlockModel
    {
        public FrostedIce0() : base("Frosted Ice 0")
        {
            AddVersion("frosted_ice_0", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/frosted_ice_0");
        }
    }
}
