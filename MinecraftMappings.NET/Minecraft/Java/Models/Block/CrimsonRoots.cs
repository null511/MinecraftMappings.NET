using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CrimsonRoots : JavaBlockModel
    {
        public CrimsonRoots() : base("Crimson Roots")
        {
            AddVersion("crimson_roots", "1.16")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/crimson_roots");
        }
    }
}
