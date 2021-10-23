using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Farmland : JavaBlockModel
    {
        public Farmland() : base("Farmland")
        {
            AddVersion("farmland", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_farmland")
                .AddTexture("top", "block/farmland")
                .AddTexture("dirt", "block/dirt");
        }
    }
}
