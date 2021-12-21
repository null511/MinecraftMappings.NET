using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class JungleTrapdoorTop : JavaBlockModel
    {
        public JungleTrapdoorTop() : base("Jungle Trapdoor, Top")
        {
            AddVersion("jungle_trapdoor_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_top")
                .AddTexture("texture", "block/jungle_trapdoor");
        }
    }
}
