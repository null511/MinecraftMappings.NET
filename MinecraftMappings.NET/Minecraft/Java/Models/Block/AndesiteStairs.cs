using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AndesiteStairs : JavaBlockModel
    {
        public AndesiteStairs() : base("Andesite Stairs")
        {
            AddVersion("andesite_stairs", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stairs")
                .AddTexture("top", "block/andesite")
                .AddTexture("bottom", "block/andesite")
                .AddTexture("side", "block/andesite");
        }
    }
}
