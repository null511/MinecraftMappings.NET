using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class StoneSlabTop : JavaBlockModel
    {
        public StoneSlabTop() : base("Stone Slab, Top")
        {
            AddVersion("stone_slab_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/slab_top")
                .AddTexture("top", "block/stone")
                .AddTexture("bottom", "block/stone")
                .AddTexture("side", "block/stone");
        }
    }
}
