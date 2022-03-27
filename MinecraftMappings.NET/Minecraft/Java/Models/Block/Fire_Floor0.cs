using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Fire_Floor0 : JavaBlockModel
    {
        public Fire_Floor0() : base("Fire, Floor 0")
        {
            AddVersion("fire_floor0", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fire_floor")
                .AddTexture("fire", "block/fire_0");
        }
    }
}
