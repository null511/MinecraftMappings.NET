using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Dropper : JavaBlockModel
    {
        public Dropper() : base("Dropper")
        {
            AddVersion("dropper", "1.5")
                .WithPath("models/block")
                .WithParent("block/orientable")
                .AddTexture("top", "block/furnace_top")
                .AddTexture("front", "block/dropper_front")
                .AddTexture("side", "block/furnace_side");
        }
    }
}
