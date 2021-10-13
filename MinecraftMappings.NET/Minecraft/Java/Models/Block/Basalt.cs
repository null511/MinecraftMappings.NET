using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Basalt : JavaBlockModel
    {
        public Basalt() : base("Basalt")
        {
            AddVersion("basalt", "1.16")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/basalt_top")
                .AddTexture("side", "block/basalt_side");
        }
    }
}
