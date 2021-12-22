using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class HayBlockHorizontal : JavaBlockModel
    {
        public HayBlockHorizontal() : base("Hay Block, Horizontal")
        {
            AddVersion("hay_block_horizontal", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column_horizontal")
                .AddTexture("end", "block/hay_block_top")
                .AddTexture("side", "block/hay_block_side");
        }
    }
}
