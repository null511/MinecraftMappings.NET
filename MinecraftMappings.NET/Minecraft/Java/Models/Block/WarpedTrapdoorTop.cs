using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedTrapdoorTop : JavaBlockModel
    {
        public WarpedTrapdoorTop() : base("Warped Trapdoor, Top")
        {
            AddVersion("warped_trapdoor_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_top")
                .AddTexture("texture", "block/warped_trapdoor");
        }
    }
}
