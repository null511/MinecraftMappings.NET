using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueOrchid : JavaModelData
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
