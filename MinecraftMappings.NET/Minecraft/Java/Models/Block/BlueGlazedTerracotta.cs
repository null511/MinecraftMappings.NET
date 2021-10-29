using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueGlazedTerracotta : JavaBlockModel
    {
        public BlueGlazedTerracotta() : base("Blue Glazed Terracotta")
        {
            AddVersion("blue_glazed_terracotta", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_glazed_terracotta")
                .AddTexture("pattern", "block/blue_glazed_terracotta");
        }
    }
}
