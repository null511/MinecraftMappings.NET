using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class MossyCobblestone : JavaBlockModel
    {
        public MossyCobblestone() : base("Mossy Cobblestone")
        {
            AddVersion("mossy_cobblestone", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/mossy_cobblestone");
        }
    }
}
