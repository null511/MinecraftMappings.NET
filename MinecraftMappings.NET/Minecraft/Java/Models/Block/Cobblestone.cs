using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cobblestone : JavaBlockModel
    {
        public Cobblestone() : base("Cobblestone")
        {
            AddVersion("cobblestone", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/cobblestone");
        }
    }
}
