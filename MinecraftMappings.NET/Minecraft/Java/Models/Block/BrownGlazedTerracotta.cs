using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownGlazedTerracotta : JavaBlockModel
    {
        public BrownGlazedTerracotta() : base("Brown Glazed Terracotta")
        {
            AddVersion("brown_glazed_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glazed_terracotta")
                .AddTexture("pattern", "block/brown_glazed_terracotta");
        }
    }
}
