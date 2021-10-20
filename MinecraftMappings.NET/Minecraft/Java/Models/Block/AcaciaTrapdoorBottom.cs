using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaTrapdoorBottom : JavaBlockModel
    {
        public AcaciaTrapdoorBottom() : base("Acacia Trapdoor, Bottom")
        {
            AddVersion("acacia_trapdoor_bottom", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_bottom")
                .AddTexture("texture", "block/acacia_trapdoor");
        }
    }
}
