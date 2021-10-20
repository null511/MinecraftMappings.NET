using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Orientable : JavaBlockModel
    {
        public Orientable() : base("Orientable")
        {
            AddVersion("orientable", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/orientable_with_bottom")
                .AddTexture("bottom", "#top");
        }
    }
}
