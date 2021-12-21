using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CrimsonTrapdoorTop : JavaBlockModel
    {
        public CrimsonTrapdoorTop() : base("Crimson Trapdoor, Top")
        {
            AddVersion("crimson_trapdoor_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_top")
                .AddTexture("texture", "block/crimson_trapdoor");
        }
    }
}
