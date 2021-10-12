using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Dispenser : JavaModelData
    {
        public Dispenser() : base("Dispenser")
        {
            AddVersion("dispenser", "1.2")
                .WithPath("models/block")
                .WithParent("block/orientable")
                .AddTexture("top", "block/furnace_top")
                .AddTexture("front", "block/dispenser_front")
                .AddTexture("side", "block/furnace_side");
        }
    }
}
