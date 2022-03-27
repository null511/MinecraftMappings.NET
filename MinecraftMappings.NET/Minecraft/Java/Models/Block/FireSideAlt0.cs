using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FireSideAlt0 : JavaBlockModel
    {
        public FireSideAlt0() : base("Fire, Side Alt 0")
        {
            AddVersion("fire_side_alt0", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fire_side_alt")
                .AddTexture("fire", "block/fire_0");
        }
    }
}
