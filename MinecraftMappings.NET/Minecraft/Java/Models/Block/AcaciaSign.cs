using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaSign : JavaBlockModel
    {
        public AcaciaSign() : base("Acacia Sign")
        {
            AddVersion("acacia_sign", "1.0.0")
                .WithPath("models/block");
        }
    }
}
