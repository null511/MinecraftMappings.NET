using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class EmeraldOre : JavaBlockModel
    {
        public EmeraldOre() : base("Emerald Ore")
        {
            AddVersion("emerald_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/emerald_ore");
        }
    }
}
