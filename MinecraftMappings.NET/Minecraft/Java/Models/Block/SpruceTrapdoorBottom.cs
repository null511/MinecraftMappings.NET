using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SpruceTrapdoorBottom : JavaBlockModel
    {
        public SpruceTrapdoorBottom() : base("Spruce Trapdoor, Bottom")
        {
            AddVersion("spruce_trapdoor_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_bottom")
                .AddTexture("texture", "block/spruce_trapdoor");
        }
    }
}
