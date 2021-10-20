using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Barrier : JavaBlockModel
    {
        public Barrier() : base("Barrier")
        {
            AddVersion("barrier", "1.0.0")
                .WithPath("models/block");
        }
    }
}
