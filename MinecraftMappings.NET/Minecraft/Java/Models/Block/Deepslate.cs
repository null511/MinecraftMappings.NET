using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Deepslate : JavaBlockModel
    {
        public Deepslate() : base("Deepslate")
        {
            AddVersion("deepslate", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/deepslate_top")
                .AddTexture("side", "block/deepslate");
        }
    }
}
