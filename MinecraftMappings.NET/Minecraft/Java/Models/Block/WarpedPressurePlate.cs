using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedPressurePlate : JavaBlockModel
    {
        public WarpedPressurePlate() : base("Warped Pressure Plate")
        {
            AddVersion("warped_pressure_plate", "1.16")
                .WithPath("models/block")
                .WithParent("block/pressure_plate_up")
                .AddTexture("texture", "block/warped_planks");
        }
    }
}
