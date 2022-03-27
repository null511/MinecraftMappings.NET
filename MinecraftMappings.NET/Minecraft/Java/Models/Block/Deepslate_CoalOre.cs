using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Deepslate_CoalOre : JavaBlockModel
    {
        public Deepslate_CoalOre() : base("Deepslate, Coal Ore")
        {
            AddVersion("deepslate_coal_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/deepslate_coal_ore");
        }
    }
}
