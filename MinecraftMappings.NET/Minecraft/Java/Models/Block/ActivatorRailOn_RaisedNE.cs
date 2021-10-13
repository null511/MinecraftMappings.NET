using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ActivatorRailOn_RaisedNE : JavaBlockModel
    {
        public ActivatorRailOn_RaisedNE() : base("Activator Rail, On, Raised NE")
        {
            AddVersion("activator_rail_on_raised_ne", "1.5")
                .WithPath("models/block")
                .WithParent("block/template_rail_on_raised_ne")
                .AddTexture("rail", "block/activator_rail_on");
        }
    }
}
