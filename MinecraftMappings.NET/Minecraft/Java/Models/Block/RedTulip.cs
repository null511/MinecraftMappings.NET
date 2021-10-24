using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RedTulip : JavaBlockModel
    {
        public RedTulip() : base("Red Tulip")
        {
            AddVersion("red_tulip", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/red_tulip");
        }
    }
}
