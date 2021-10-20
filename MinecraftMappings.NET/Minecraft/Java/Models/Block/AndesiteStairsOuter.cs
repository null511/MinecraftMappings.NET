using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AndesiteStairsOuter : JavaBlockModel
    {
        public AndesiteStairsOuter() : base("Andesite Stairs, Outer")
        {
            AddVersion("andesite_stairs_outer", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/outer_stairs")
                .AddTexture("top", "block/andesite")
                .AddTexture("bottom", "block/andesite")
                .AddTexture("side", "block/andesite");
        }
    }
}
