using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SpruceTrapdoorTop : JavaBlockModel
    {
        public SpruceTrapdoorTop() : base("Spruce Trapdoor, Top")
        {
            AddVersion("spruce_trapdoor_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_top")
                .AddTexture("texture", "block/spruce_trapdoor");
        }
    }
}
