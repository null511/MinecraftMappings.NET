using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Dispenser : JavaBlockModel
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
