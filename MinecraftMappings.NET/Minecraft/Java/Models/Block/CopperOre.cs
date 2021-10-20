using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CopperOre : JavaBlockModel
    {
        public CopperOre() : base("Copper Ore")
        {
            AddVersion("copper_ore", "1.17")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/copper_ore");
        }
    }
}
