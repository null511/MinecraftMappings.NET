using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ThinBlock : JavaBlockModel
    {
        public ThinBlock() : base("Thin Block")
        {
            AddVersion("thin_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/block");
        }
    }
}
