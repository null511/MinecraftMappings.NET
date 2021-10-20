using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AzaleaLeaves : JavaBlockModel
    {
        public AzaleaLeaves() : base("Azalea Leaves")
        {
            AddVersion("azalea_leaves", "1.17")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/azalea_leaves");
        }
    }
}
