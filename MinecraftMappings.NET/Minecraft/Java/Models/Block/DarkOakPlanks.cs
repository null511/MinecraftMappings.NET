using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DarkOakPlanks : JavaBlockModel
    {
        public DarkOakPlanks() : base("Dark Oak Planks")
        {
            AddVersion("dark_oak_planks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/dark_oak_planks");
        }
    }
}
