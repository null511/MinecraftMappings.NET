using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FloweringAzalea : JavaBlockModel
    {
        public FloweringAzalea() : base("Flowering Azalea")
        {
            AddVersion("flowering_azalea", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_azalea")
                .AddTexture("top", "block/flowering_azalea_top")
                .AddTexture("side", "block/flowering_azalea_side");
        }
    }
}
