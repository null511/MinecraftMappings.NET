using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedPressurePlate_Down : JavaBlockModel
    {
        public WarpedPressurePlate_Down() : base("Warped Pressure Plate, Down")
        {
            AddVersion("warped_pressure_plate_down", "1.16")
                .WithPath("models/block")
                .WithParent("block/pressure_plate_down")
                .AddTexture("texture", "block/warped_planks");
        }
    }
}
