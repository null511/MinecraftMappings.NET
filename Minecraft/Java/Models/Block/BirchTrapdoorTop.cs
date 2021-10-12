using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BirchTrapdoorTop : JavaModelData
    {
        public BirchTrapdoorTop() : base("Birch Trapdoor, Top")
        {
            AddVersion("birch_trapdoor_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_top")
                .AddTexture("texture", "block/birch_trapdoor");
        }
    }
}
