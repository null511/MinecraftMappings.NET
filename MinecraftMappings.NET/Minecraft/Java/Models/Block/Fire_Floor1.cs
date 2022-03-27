using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Fire_Floor1 : JavaBlockModel
    {
        public Fire_Floor1() : base("Fire, Floor 1")
        {
            AddVersion("fire_floor1", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_fire_floor")
                .AddTexture("fire", "block/fire_1");
        }
    }
}
