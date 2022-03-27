using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FireUpAlt1 : JavaBlockModel
    {
        public FireUpAlt1() : base("Fire, Up Alt 1")
        {
            AddVersion("fire_up_alt1", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fire_up_alt")
                .AddTexture("fire", "block/fire_1");
        }
    }
}
