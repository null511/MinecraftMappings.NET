using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class HayBlock : JavaBlockModel
    {
        public HayBlock() : base("Hay Block")
        {
            AddVersion("hay_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/hay_block_top")
                .AddTexture("side", "block/hay_block_side");
        }
    }
}
