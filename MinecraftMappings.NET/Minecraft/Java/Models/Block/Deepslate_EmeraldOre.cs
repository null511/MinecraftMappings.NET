using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Deepslate_EmeraldOre : JavaBlockModel
    {
        public Deepslate_EmeraldOre() : base("Deepslate, Emerald Ore")
        {
            AddVersion("deepslate_emerald_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/deepslate_emerald_ore");
        }
    }
}
