using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DiamondOre : JavaBlockModel
    {
        public DiamondOre() : base("Diamond Ore")
        {
            AddVersion("diamond_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/diamond_ore");
        }
    }
}
