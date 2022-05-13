using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedWartBlock : JavaBlockModel
    {
        public WarpedWartBlock() : base("Warped Wart Block")
        {
            AddVersion("warped_wart_block", "1.16")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/warped_wart_block");
        }
    }
}
