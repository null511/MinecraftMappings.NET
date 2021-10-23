using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class NetherSprouts : JavaBlockModel
    {
        public NetherSprouts() : base("Nether Sprouts")
        {
            AddVersion("nether_sprouts", "1.16")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/nether_sprouts");
        }
    }
}
