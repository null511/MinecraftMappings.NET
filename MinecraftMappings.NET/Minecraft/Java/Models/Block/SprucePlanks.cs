using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SprucePlanks : JavaBlockModel
    {
        public SprucePlanks() : base("Spruce Planks")
        {
            AddVersion("spruce_planks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/spruce_planks");
        }
    }
}
