using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Deepslate_RedstoneOre : JavaBlockModel
    {
        public Deepslate_RedstoneOre() : base("Deepslate, Redstone Ore")
        {
            AddVersion("deepslate_redstone_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/deepslate_redstone_ore");
        }
    }
}
