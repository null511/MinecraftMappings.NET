using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FrostedIce3 : JavaBlockModel
    {
        public FrostedIce3() : base("Frosted Ice 3")
        {
            AddVersion("frosted_ice_3", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/frosted_ice_3");
        }
    }
}
