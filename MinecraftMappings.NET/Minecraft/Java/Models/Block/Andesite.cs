using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Andesite : JavaBlockModel
    {
        public Andesite() : base("Andesite")
        {
            AddVersion("andesite", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/andesite");
        }
    }
}
