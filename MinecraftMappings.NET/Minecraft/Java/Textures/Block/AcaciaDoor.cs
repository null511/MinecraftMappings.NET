using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaDoor : JavaBlockData
    {
        public AcaciaDoor() : base("Acacia Door")
        {
            AddVersion("acacia_door")
                .WithDefaultModel<Java.Models.Block.AcaciaDoor>();
        }
    }
}
