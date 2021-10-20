using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class GrassBlockSnow : JavaBlockModel
    {
        public GrassBlockSnow() : base("Grass Block, Snow")
        {
            AddVersion("grass_block_snow", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_bottom_top")
                .AddTexture("top", "block/grass_block_top")
                .AddTexture("bottom", "block/dirt")
                .AddTexture("side", "block/grass_block_snow");
        }
    }
}
