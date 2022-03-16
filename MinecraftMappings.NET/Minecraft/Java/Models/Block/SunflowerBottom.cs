using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SunflowerBottom : JavaBlockModel
    {
        public SunflowerBottom() : base("Sunflower Bottom")
        {
            AddVersion("sunflower_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/sunflower_bottom");
        }
    }
}
