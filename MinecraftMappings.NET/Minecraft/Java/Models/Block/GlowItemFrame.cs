using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class GlowItemFrame : JavaBlockModel
    {
        public GlowItemFrame() : base("Glow Item Frame")
        {
            AddVersion("glow_item_frame", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_item_frame")
                .AddTexture("wood", "block/birch_planks")
                .AddTexture("back", "block/glow_item_frame");
        }
    }
}
