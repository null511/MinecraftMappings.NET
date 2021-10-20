using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Furnace : JavaBlockModel
    {
        public Furnace() : base("Furnace")
        {
            AddVersion("furnace", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/orientable")
                .AddTexture("top", "block/furnace_top")
                .AddTexture("front", "block/furnace_front")
                .AddTexture("side", "block/furnace_side");
        }
    }
}
