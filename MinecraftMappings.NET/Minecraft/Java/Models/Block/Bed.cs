using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Bed : JavaBlockModel
    {
        public Bed() : base("Bed")
        {
            AddVersion("bed", "1.0.0")
                .WithPath("models/block");
        }
    }
}
