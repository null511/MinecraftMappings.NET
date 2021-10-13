using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ActivatorRailOn : JavaBlockModel
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
