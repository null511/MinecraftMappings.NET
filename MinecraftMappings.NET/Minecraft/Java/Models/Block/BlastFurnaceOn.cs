using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlastFurnaceOn : JavaBlockModel
    {
        public BlastFurnaceOn() : base("Blast Furnace, On")
        {
            AddVersion("blast_furnace_on", "1.14")
                .WithPath("models/block")
                .WithParent("block/orientable")
                .AddTexture("top", "block/blast_furnace_top")
                .AddTexture("front", "block/blast_furnace_front_on")
                .AddTexture("side", "block/blast_furnace_side");
        }
    }
}
