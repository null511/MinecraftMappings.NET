using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BirchPlanks : JavaBlockModel
    {
        public BirchPlanks() : base("Birch Planks")
        {
            AddVersion("birch_planks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/birch_planks");
        }
    }
}
