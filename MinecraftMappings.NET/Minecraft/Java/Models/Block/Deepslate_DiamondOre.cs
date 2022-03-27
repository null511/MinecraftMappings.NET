using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Deepslate_DiamondOre : JavaBlockModel
    {
        public Deepslate_DiamondOre() : base("Deepslate, Diamond Ore")
        {
            AddVersion("deepslate_diamond_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/deepslate_diamond_ore");
        }
    }
}
