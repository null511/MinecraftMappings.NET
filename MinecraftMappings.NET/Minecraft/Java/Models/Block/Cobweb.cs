using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cobweb : JavaBlockModel
    {
        public Cobweb() : base("Cobweb")
        {
            AddVersion("cobweb", "1.5")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/cobweb");
        }
    }
}
