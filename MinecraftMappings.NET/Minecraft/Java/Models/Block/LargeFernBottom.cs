using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class LargeFernBottom : JavaBlockModel
    {
        public LargeFernBottom() : base("Large Fern Bottom")
        {
            AddVersion("large_fern_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/large_fern_bottom");
        }
    }
}
