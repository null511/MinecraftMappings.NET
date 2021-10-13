using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ActivatorRailOn_RaisedSW : JavaBlockModel
    {
        public ActivatorRailOn_RaisedSW() : base("Activator Rail, On, Raised SW")
        {
            AddVersion("activator_rail_on_raised_sw", "1.5")
                .WithPath("models/block")
                .WithParent("block/template_rail_on_raised_sw")
                .AddTexture("rail", "block/activator_rail_on");
        }
    }
}
