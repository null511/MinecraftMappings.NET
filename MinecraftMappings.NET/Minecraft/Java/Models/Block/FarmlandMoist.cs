using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FarmlandMoist : JavaBlockModel
    {
        public FarmlandMoist() : base("Farmland, Moist")
        {
            AddVersion("farmland_moist", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_farmland")
                .AddTexture("top", "block/farmland_moist")
                .AddTexture("dirt", "block/dirt");
        }
    }
}
