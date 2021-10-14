using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OakTrapdoorTop : JavaBlockModel
    {
        public OakTrapdoorTop() : base("Oak Trapdoor, Top")
        {
            AddVersion("oak_trapdoor_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_top")
                .AddTexture("texture", "block/oak_trapdoor");
        }
    }
}
