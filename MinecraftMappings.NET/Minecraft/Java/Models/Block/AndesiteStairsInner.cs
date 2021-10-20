using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AndesiteStairsInner : JavaBlockModel
    {
        public AndesiteStairsInner() : base("Andesite Stairs, Inner")
        {
            AddVersion("andesite_stairs_inner", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/inner_stairs")
                .AddTexture("top", "block/andesite")
                .AddTexture("bottom", "block/andesite")
                .AddTexture("side", "block/andesite");
        }
    }
}
