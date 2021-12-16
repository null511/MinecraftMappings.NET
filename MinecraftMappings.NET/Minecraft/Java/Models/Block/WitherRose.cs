using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WitherRose : JavaBlockModel
    {
        public WitherRose() : base("Wither Rose")
        {
            AddVersion("wither_rose", "1.14")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/wither_rose");
        }
    }
}
