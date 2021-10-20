using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AndesiteSlabTop : JavaBlockModel
    {
        public AndesiteSlabTop() : base("Andesite Slab, Top")
        {
            AddVersion("andesite_slab_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab_top")
                .AddTexture("top", "block/andesite")
                .AddTexture("bottom", "block/andesite")
                .AddTexture("side", "block/andesite");
        }
    }
}
