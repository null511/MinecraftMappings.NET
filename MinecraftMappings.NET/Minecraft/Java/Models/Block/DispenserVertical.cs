using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DispenserVertical : JavaBlockModel
    {
        public DispenserVertical() : base("Dispenser, Vertical")
        {
            AddVersion("dispenser_vertical", "1.2")
                .WithPath("models/block")
                .WithParent("block/orientable_vertical")
                .AddTexture("front", "block/dispenser_front_vertical")
                .AddTexture("side", "block/furnace_top");
        }
    }
}
