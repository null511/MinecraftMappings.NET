using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OakPlanks : JavaBlockModel
    {
        public OakPlanks() : base("Oak Planks")
        {
            AddVersion("oak_planks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/oak_planks");
        }
    }
}
