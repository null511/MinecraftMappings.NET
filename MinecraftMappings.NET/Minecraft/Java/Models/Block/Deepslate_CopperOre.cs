using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Deepslate_CopperOre : JavaBlockModel
    {
        public Deepslate_CopperOre() : base("Deepslate, Copper Ore")
        {
            AddVersion("deepslate_copper_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/deepslate_copper_ore");
        }
    }
}
