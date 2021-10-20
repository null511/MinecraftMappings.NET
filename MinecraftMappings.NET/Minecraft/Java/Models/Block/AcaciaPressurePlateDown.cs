using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaPressurePlateDown : JavaBlockModel
    {
        public AcaciaPressurePlateDown() : base("Acacia Pressure Plate, Down")
        {
            AddVersion("acacia_pressure_plate_down", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/pressure_plate_down")
                .AddTexture("texture", "block/acacia_planks");
        }
    }
}
