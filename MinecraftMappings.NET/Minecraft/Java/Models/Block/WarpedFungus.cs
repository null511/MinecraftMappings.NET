using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedFungus : JavaBlockModel
    {
        public WarpedFungus() : base("Warped Fungus")
        {
            AddVersion("warped_fungus", "1.16")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/warped_fungus");
        }
    }
}
