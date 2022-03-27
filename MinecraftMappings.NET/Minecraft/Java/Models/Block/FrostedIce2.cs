using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FrostedIce2 : JavaBlockModel
    {
        public FrostedIce2() : base("Frosted Ice 2")
        {
            AddVersion("frosted_ice_2", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/frosted_ice_2");
        }
    }
}
