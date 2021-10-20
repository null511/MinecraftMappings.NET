using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CarvedPumpkin : JavaBlockModel
    {
        public CarvedPumpkin() : base("Carved Pumpkin")
        {
            AddVersion("carved_pumpkin", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/orientable")
                .AddTexture("top", "block/pumpkin_top")
                .AddTexture("front", "block/carved_pumpkin")
                .AddTexture("side", "block/pumpkin_side");
        }
    }
}
