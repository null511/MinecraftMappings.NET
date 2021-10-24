using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DropperVertical : JavaBlockModel
    {
        public DropperVertical() : base("Dropper, Vertical")
        {
            AddVersion("dropper_vertical", "1.5")
                .WithPath("models/block")
                .WithParent("block/orientable_vertical")
                .AddTexture("front", "block/dropper_front_vertical")
                .AddTexture("side", "block/furnace_top");
        }
    }
}
