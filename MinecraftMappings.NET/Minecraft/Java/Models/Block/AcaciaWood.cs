using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaWood : JavaBlockModel
    {
        public AcaciaWood() : base("Acacia Wood")
        {
            AddVersion("acacia_wood", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/acacia_log")
                .AddTexture("side", "block/acacia_log");
        }
    }
}
