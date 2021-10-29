using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackGlazedTerracotta : JavaBlockModel
    {
        public BlackGlazedTerracotta() : base("Black Glazed Terracotta")
        {
            AddVersion("black_glazed_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glazed_terracotta")
                .AddTexture("pattern", "block/black_glazed_terracotta");
        }
    }
}
