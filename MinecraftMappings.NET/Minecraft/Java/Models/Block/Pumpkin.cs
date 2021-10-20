using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Pumpkin : JavaBlockModel
    {
        public Pumpkin() : base("Pumpkin")
        {
            AddVersion("pumpkin", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/pumpkin_top")
                .AddTexture("side", "block/pumpkin_side");
        }
    }
}
