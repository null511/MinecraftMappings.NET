using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CobblestoneStairs : JavaBlockModel
    {
        public CobblestoneStairs() : base("Cobblestone Stairs")
        {
            AddVersion("cobblestone_stairs", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/stairs")
                .AddTexture("bottom", "block/cobblestone")
                .AddTexture("top", "block/cobblestone")
                .AddTexture("side", "block/cobblestone");
        }
    }
}
