using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class GildedBlackstone : JavaBlockModel
    {
        public GildedBlackstone() : base("Gilded Blackstone")
        {
            AddVersion("gilded_blackstone", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/gilded_blackstone");
        }
    }
}
