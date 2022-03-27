using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Deepslate_LapisOre : JavaBlockModel
    {
        public Deepslate_LapisOre() : base("Deepslate, Lapis Ore")
        {
            AddVersion("deepslate_lapis_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/deepslate_lapis_ore");
        }
    }
}
