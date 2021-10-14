using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class SpruceTrapdoorOpen : JavaBlockModel
    {
        public SpruceTrapdoorOpen() : base("Spruce Trapdoor, Open")
        {
            AddVersion("spruce_trapdoor_open", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_open")
                .AddTexture("texture", "block/spruce_trapdoor");
        }
    }
}
