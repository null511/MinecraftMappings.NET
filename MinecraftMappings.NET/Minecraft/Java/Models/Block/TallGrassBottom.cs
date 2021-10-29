using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TallGrassBottom : JavaBlockModel
    {
        public TallGrassBottom() : base("Tall Grass Bottom")
        {
            AddVersion("tall_grass_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tinted_cross")
                .AddTexture("cross", "block/tall_grass_bottom");
        }
    }
}
