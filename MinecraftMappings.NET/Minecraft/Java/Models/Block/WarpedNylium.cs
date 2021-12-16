using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedNylium : JavaBlockModel
    {
        public WarpedNylium() : base("Warped Nylium")
        {
            AddVersion("warped_nylium", "1.16")
                .WithPath("models/block")
                .WithParent("block/cube_bottom_top")
                .AddTexture("top", "block/warped_nylium")
                .AddTexture("bottom", "block/netherrack")
                .AddTexture("side", "block/warped_nylium_side");
        }
    }
}
