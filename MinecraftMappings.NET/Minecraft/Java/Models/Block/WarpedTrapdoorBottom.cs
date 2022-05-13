using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedTrapdoorBottom : JavaBlockModel
    {
        public WarpedTrapdoorBottom() : base("Warped Trapdoor, Bottom")
        {
            AddVersion("warped_trapdoor_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_bottom")
                .AddTexture("texture", "block/warped_trapdoor");
        }
    }
}
