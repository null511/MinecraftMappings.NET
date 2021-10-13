using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaDoor : JavaBlockTexture
    {
        public AcaciaDoor() : base("Acacia Door")
        {
            AddVersion("acacia_door")
                .WithDefaultModel<Java.Models.Block.AcaciaDoor>();
        }
    }
}
