using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ChiseledDeepslate : JavaBlockModel
    {
        public ChiseledDeepslate() : base("Chiseled Deepslate")
        {
            AddVersion("chiseled_deepslate", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/chiseled_deepslate");
        }
    }
}
