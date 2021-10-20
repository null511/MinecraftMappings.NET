using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FurnaceOn : JavaBlockModel
    {
        public FurnaceOn() : base("Furnace, On")
        {
            AddVersion("furnace_on", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/orientable")
                .AddTexture("top", "block/furnace_top")
                .AddTexture("front", "block/furnace_front_on")
                .AddTexture("side", "block/furnace_side");
        }
    }
}
