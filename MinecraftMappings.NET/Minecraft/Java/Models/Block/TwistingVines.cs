using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TwistingVines : JavaBlockModel
    {
        public TwistingVines() : base("Twisting Vines")
        {
            AddVersion("twisting_vines", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/twisting_vines");
        }
    }
}
