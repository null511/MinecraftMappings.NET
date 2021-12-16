using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PeonyBottom : JavaBlockModel
    {
        public PeonyBottom() : base("Peony Bottom")
        {
            AddVersion("peony_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/peony_bottom");
        }
    }
}
