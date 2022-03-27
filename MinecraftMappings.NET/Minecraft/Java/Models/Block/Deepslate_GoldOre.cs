using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Deepslate_GoldOre : JavaBlockModel
    {
        public Deepslate_GoldOre() : base("Deepslate, Gold Ore")
        {
            AddVersion("deepslate_gold_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/deepslate_gold_ore");
        }
    }
}
