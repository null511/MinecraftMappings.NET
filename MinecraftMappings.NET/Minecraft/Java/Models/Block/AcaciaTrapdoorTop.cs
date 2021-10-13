using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaTrapdoorTop : JavaBlockModel
    {
        public AcaciaTrapdoorTop() : base("Acacia Trapdoor, Top")
        {
            AddVersion("acacia_trapdoor_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_top")
                .AddTexture("texture", "block/acacia_trapdoor");
        }
    }
}
