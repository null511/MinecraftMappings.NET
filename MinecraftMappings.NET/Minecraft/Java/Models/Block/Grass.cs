using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Grass : JavaBlockModel
    {
        public Grass() : base("Grass")
        {
            AddVersion("grass", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/tinted_cross")
                .AddTexture("cross", "block/grass");
        }
    }
}
