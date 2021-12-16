using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PeonyTop : JavaBlockModel
    {
        public PeonyTop() : base("Peony Top")
        {
            AddVersion("peony_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/peony_top");
        }
    }
}
