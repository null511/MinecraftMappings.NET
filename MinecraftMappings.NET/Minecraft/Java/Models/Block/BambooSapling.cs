using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BambooSapling : JavaBlockModel
    {
        public BambooSapling() : base("Bamboo Sapling")
        {
            AddVersion("bamboo_sapling", "1.14")
                .WithPath("models/block")
                .WithParent("block/tinted_cross")
                .AddTexture("cross", "block/bamboo_stage0");
        }
    }
}
