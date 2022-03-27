using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ExposedCutCopper : JavaBlockModel
    {
        public ExposedCutCopper() : base("Exposed Cut Copper")
        {
            AddVersion("exposed_cut_copper", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/exposed_cut_copper");
        }
    }
}
