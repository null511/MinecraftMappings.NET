using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Poppy : JavaBlockModel
    {
        public Poppy() : base("Poppy")
        {
            AddVersion("poppy", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/poppy");
        }
    }
}
