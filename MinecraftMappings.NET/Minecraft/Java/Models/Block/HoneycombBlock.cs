using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class HoneycombBlock : JavaBlockModel
    {
        public HoneycombBlock() : base("Honeycomb Block")
        {
            AddVersion("honeycomb_block", "1.15")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/honeycomb_block");
        }
    }
}
