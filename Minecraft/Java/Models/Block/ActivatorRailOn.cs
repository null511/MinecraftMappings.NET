using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ActivatorRailOn : JavaModelData
    {
        public ActivatorRailOn() : base("Activator Rail, On")
        {
            AddVersion("activator_rail_on", "1.5")
                .WithPath("models/block")
                .WithParent("block/rail_flat")
                .AddTexture("rail", "block/activator_rail_on");
        }
    }
}
