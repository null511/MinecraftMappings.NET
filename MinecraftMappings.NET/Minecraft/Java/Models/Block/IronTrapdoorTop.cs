using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class IronTrapdoorTop : JavaBlockModel
    {
        public IronTrapdoorTop() : base("Iron Trapdoor, Top")
        {
            AddVersion("iron_trapdoor_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_top")
                .AddTexture("texture", "block/iron_trapdoor");
        }
    }
}
