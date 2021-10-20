using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AndesiteSlab : JavaBlockModel
    {
        public AndesiteSlab() : base("Andesite Slab")
        {
            AddVersion("andesite_slab", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab")
                .AddTexture("top", "block/andesite")
                .AddTexture("bottom", "block/andesite")
                .AddTexture("side", "block/andesite");
        }
    }
}
