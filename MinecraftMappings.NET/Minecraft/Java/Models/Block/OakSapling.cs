using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OakSapling : JavaBlockModel
    {
        public OakSapling() : base("Oak Sapling")
        {
            AddVersion("oak_sapling", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/oak_sapling");
        }
    }
}
