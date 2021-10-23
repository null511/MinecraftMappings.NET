using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OxeyeDaisy : JavaBlockModel
    {
        public OxeyeDaisy() : base("Oxeye Daisy")
        {
            AddVersion("oxeye_daisy", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/oxeye_daisy");
        }
    }
}
