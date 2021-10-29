using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TallTintedCross : JavaBlockModel
    {
        public TallTintedCross() : base("Tall Tinted Cross")
        {
            AddVersion("tall_tinted_cross", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tall_cross");
        }
    }
}
