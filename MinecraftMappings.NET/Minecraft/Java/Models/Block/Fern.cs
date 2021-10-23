using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Fern : JavaBlockModel
    {
        public Fern() : base("Fern")
        {
            AddVersion("fern", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tinted_cross")
                .AddTexture("cross", "block/fern");
        }
    }
}
