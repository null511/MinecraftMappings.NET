using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OrangeTulip : JavaBlockModel
    {
        public OrangeTulip() : base("Orange Tulip")
        {
            AddVersion("orange_tulip", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/orange_tulip");
        }
    }
}
