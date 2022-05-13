using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteGlazedTerracotta : JavaBlockModel
    {
        public WhiteGlazedTerracotta() : base("White Glazed Terracotta")
        {
            AddVersion("white_glazed_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glazed_terracotta")
                .AddTexture("pattern", "block/white_glazed_terracotta");
        }
    }
}
