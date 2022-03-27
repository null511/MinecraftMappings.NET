using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FireUp0 : JavaBlockModel
    {
        public FireUp0() : base("Fire, Up 0")
        {
            AddVersion("fire_up0", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fire_up")
                .AddTexture("fire", "block/fire_0");
        }
    }
}
