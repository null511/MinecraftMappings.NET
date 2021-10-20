using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BirchSapling : JavaBlockModel
    {
        public BirchSapling() : base("Birch Sapling")
        {
            AddVersion("birch_sapling", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/birch_sapling");
        }
    }
}
