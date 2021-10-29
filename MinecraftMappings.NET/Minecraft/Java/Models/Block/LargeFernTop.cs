using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class LargeFernTop : JavaBlockModel
    {
        public LargeFernTop() : base("Large Fern Top")
        {
            AddVersion("large_fern_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/large_fern_top");
        }
    }
}
