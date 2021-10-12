using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ActivatorRailOn_RaisedNE : JavaModelData
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
