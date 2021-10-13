using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaPlanks : JavaBlockModel
    {
        public AcaciaPlanks() : base("Acacia Planks")
        {
            AddVersion("acacia_planks", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/acacia_planks");
        }
    }
}
