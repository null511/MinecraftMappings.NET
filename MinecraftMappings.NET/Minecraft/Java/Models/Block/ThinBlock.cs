using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ThinBlock : JavaModelData
    {
        public ThinBlock() : base("Thin Block")
        {
            AddVersion("thin_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block");
        }
    }
}
