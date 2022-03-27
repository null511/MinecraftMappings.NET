using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CobbledDeepslate : JavaBlockModel
    {
        public CobbledDeepslate() : base("Cobbled Deepslate")
        {
            AddVersion("cobbled_deepslate", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/cobbled_deepslate");
        }
    }
}
