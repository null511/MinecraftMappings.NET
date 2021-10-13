using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Lantern : JavaBlockModel
    {
        public Lantern() : base("Lantern")
        {
            AddVersion("lantern", "1.14")
                .WithPath("models/block")
                .WithParent("block/template_lantern")
                .AddTexture("lantern", "block/lantern");
        }
    }
}
