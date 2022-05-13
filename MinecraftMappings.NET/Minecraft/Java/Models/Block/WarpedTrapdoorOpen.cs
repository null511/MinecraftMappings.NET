using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WarpedTrapdoorOpen : JavaBlockModel
    {
        public WarpedTrapdoorOpen() : base("Warped Trapdoor, Open")
        {
            AddVersion("warped_trapdoor_open", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_open")
                .AddTexture("texture", "block/warped_trapdoor");
        }
    }
}
