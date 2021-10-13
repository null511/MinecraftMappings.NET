using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueOrchid : JavaBlockModel
    {
        public BlueOrchid() : base("Blue Orchid")
        {
            AddVersion("blue_orchid", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/blue_orchid");
        }
    }
}
