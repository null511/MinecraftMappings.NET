using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TallGrassTop : JavaBlockModel
    {
        public TallGrassTop() : base("Tall Grass Top")
        {
            AddVersion("tall_grass_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tinted_cross")
                .AddTexture("cross", "block/tall_grass_top");
        }
    }
}
