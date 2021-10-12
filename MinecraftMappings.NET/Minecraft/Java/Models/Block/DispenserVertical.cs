using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DispenserVertical : JavaModelData
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
