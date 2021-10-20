using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlastFurnace : JavaBlockModel
    {
        public BlastFurnace() : base("Blast Furnace")
        {
            AddVersion("blast_furnace", "1.14")
                .WithPath("models/block")
                .WithParent("block/orientable")
                .AddTexture("top", "block/blast_furnace_top")
                .AddTexture("front", "block/blast_furnace_front")
                .AddTexture("side", "block/blast_furnace_side");
        }
    }
}
