using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Deepslate_IronOre : JavaBlockModel
    {
        public Deepslate_IronOre() : base("Deepslate, Iron Ore")
        {
            AddVersion("deepslate_iron_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/deepslate_iron_ore");
        }
    }
}
