using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PoweredRail : JavaBlockModel
    {
        public PoweredRail() : base("Powered Rail")
        {
            AddVersion("powered_rail", "1.5")
                .WithPath("models/block")
                .WithParent("block/rail_flat")
                .AddTexture("rail", "block/powered_rail");
        }
    }
}
