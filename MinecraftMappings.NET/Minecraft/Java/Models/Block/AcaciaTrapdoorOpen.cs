using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AcaciaTrapdoorOpen : JavaBlockModel
    {
        public AcaciaTrapdoorOpen() : base("Acacia Trapdoor, Open")
        {
            AddVersion("acacia_trapdoor_open", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_orientable_trapdoor_open")
                .AddTexture("texture", "block/acacia_trapdoor");
        }
    }
}
