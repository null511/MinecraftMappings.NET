using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Air : JavaBlockModel
    {
        public Air() : base("Air")
        {
            AddVersion("air", "1.0.0")
                .WithPath("models/block");
        }
    }
}
