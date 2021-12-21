using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DarkOakTrapdoorTop : JavaBlockModel
    {
        public DarkOakTrapdoorTop() : base("Dark Oak Trapdoor, Top")
        {
            AddVersion("dark_oak_trapdoor_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_top")
                .AddTexture("texture", "block/dark_oak_trapdoor");
        }
    }
}
