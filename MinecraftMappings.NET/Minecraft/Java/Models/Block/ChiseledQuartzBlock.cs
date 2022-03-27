using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChiseledQuartzBlock : JavaBlockModel
    {
        public ChiseledQuartzBlock() : base("Chiseled Quartz Block")
        {
            AddVersion("chiseled_quartz_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/chiseled_quartz_block_top")
                .AddTexture("side", "block/chiseled_quartz_block");
        }
    }
}
