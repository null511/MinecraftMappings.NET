using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WaterCauldron_Full : JavaBlockModel
    {
        public WaterCauldron_Full() : base("Water Cauldron, Full")
        {
            AddVersion("water_cauldron_full", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_cauldron_full")
                .AddTexture("content", "block/water_still")
                .AddTexture("inside", "block/cauldron_inner")
                .AddTexture("top", "block/cauldron_top")
                .AddTexture("bottom", "block/cauldron_bottom")
                .AddTexture("side", "block/cauldron_side");
        }
    }
}
