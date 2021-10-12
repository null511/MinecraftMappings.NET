using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SoulLantern : JavaModelData
    {
        public SoulLantern() : base("Soul Lantern")
        {
            AddVersion("soul_lantern", "1.14")
                .WithPath("models/block")
                .WithParent("block/template_lantern")
                .AddTexture("lantern", "block/soul_lantern");
        }
    }
}
