using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PinkTulip : JavaBlockModel
    {
        public PinkTulip() : base("Pink Tulip")
        {
            AddVersion("pink_tulip", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/pink_tulip");
        }
    }
}
