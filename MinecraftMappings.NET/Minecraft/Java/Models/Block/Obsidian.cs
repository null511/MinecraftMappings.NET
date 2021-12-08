using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Obsidian : JavaBlockModel
    {
        public Obsidian() : base("Obsidian")
        {
            AddVersion("obsidian", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/obsidian");
        }
    }
}
