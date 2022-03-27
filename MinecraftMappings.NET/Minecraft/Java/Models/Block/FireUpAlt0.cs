using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FireUpAlt0 : JavaBlockModel
    {
        public FireUpAlt0() : base("Fire, Up Alt 0")
        {
            AddVersion("fire_up_alt0", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fire_up_alt")
                .AddTexture("fire", "block/fire_0");
        }
    }
}
