using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Fire_Side1 : JavaBlockModel
    {
        public Fire_Side1() : base("Fire, Side 1")
        {
            AddVersion("fire_side1", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fire_side")
                .AddTexture("fire", "block/fire_1");
        }
    }
}
