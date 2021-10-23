using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Kelp : JavaBlockModel
    {
        public Kelp() : base("Kelp")
        {
            AddVersion("kelp", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tinted_cross")
                .AddTexture("cross", "block/kelp");
        }
    }
}
