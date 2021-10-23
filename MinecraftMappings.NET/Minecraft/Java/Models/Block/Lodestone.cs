using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Lodestone : JavaBlockModel
    {
        public Lodestone() : base("Lodestone")
        {
            AddVersion("lodestone", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/lodestone_top")
                .AddTexture("side", "block/lodestone_side");
        }
    }
}
