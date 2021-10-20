using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaPressurePlate : JavaBlockModel
    {
        public AcaciaPressurePlate() : base("Acacia Pressure Plate")
        {
            AddVersion("acacia_pressure_plate", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/pressure_plate_up")
                .AddTexture("texture", "block/acacia_planks");
        }
    }
}
