using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FloweringAzaleaLeaves : JavaBlockModel
    {
        public FloweringAzaleaLeaves() : base("Flowering Azalea Leaves")
        {
            AddVersion("flowering_azalea_leaves", "1.17")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/flowering_azalea_leaves");
        }
    }
}
