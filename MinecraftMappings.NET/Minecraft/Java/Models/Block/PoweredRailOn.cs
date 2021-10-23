using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PoweredRailOn : JavaBlockModel
    {
        public PoweredRailOn() : base("Powered Rail, On")
        {
            AddVersion("powered_rail_on", "1.5")
                .WithPath("models/block")
                .WithParent("block/rail_flat")
                .AddTexture("rail", "block/powered_rail_on");
        }
    }
}
