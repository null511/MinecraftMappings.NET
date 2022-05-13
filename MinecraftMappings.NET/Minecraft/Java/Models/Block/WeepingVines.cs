using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WeepingVines : JavaBlockModel
    {
        public WeepingVines() : base("Weeping Vines")
        {
            AddVersion("weeping_vines", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/weeping_vines");
        }
    }
}
