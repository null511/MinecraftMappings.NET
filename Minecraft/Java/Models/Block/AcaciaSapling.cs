using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaSapling : JavaModelData
    {
        public AcaciaSapling() : base("Acacia Sapling")
        {
            AddVersion("acacia_sapling", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/acacia_sapling");
        }
    }
}
