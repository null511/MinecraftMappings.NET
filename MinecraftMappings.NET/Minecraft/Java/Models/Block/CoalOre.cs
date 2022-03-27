using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CoalOre : JavaBlockModel
    {
        public CoalOre() : base("Coal Ore")
        {
            AddVersion("coal_ore", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/coal_ore");
        }
    }
}
