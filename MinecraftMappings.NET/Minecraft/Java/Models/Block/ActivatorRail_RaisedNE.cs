using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ActivatorRail_RaisedNE : JavaModelData
    {
        public ActivatorRail_RaisedNE() : base("Activator Rail, Raised NE")
        {
            AddVersion("activator_rail_raised_ne", "1.5")
                .WithPath("models/block")
                .WithParent("block/template_rail_raised_ne")
                .AddTexture("rail", "block/activator_rail");
        }
    }
}
