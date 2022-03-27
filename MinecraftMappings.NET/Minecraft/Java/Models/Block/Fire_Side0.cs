using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Fire_Side0 : JavaBlockModel
    {
        public Fire_Side0() : base("Fire, Side 0")
        {
            AddVersion("fire_side0", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fire_side")
                .AddTexture("fire", "block/fire_0");
        }
    }
}
