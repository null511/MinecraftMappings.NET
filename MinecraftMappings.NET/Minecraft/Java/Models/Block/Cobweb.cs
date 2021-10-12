using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cobweb : JavaModelData
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
