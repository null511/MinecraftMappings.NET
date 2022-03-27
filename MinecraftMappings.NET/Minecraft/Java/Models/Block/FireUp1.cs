using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FireUp1 : JavaBlockModel
    {
        public FireUp1() : base("Fire, Up 1")
        {
            AddVersion("fire_up1", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fire_up")
                .AddTexture("fire", "block/fire_1");
        }
    }
}
