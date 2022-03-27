using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ExposedCopper : JavaBlockModel
    {
        public ExposedCopper() : base("Exposed Copper")
        {
            AddVersion("exposed_copper", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/exposed_copper");
        }
    }
}
