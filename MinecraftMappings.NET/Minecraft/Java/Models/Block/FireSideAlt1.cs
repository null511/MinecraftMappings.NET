using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FireSideAlt1 : JavaBlockModel
    {
        public FireSideAlt1() : base("Fire, Side Alt 1")
        {
            AddVersion("fire_side_alt1", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fire_side_alt")
                .AddTexture("fire", "block/fire_1");
        }
    }
}
