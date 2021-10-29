using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TallGrass : JavaBlockModel
    {
        public TallGrass() : base("Tall Grass")
        {
            AddVersion("tall_grass", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tall_tinted_cross")
                .AddTexture("cross_top", "block/tall_grass_top")
                .AddTexture("cross_bottom", "block/tall_grass_bottom");
        }
    }
}
