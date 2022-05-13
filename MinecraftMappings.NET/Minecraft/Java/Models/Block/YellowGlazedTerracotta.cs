using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class YellowGlazedTerracotta : JavaBlockModel
    {
        public YellowGlazedTerracotta() : base("Yellow Glazed Terracotta")
        {
            AddVersion("yellow_glazed_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glazed_terracotta")
                .AddTexture("pattern", "block/yellow_glazed_terracotta");
        }
    }
}
