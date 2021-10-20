using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Azalea : JavaBlockModel
    {
        public Azalea() : base("Azalea")
        {
            AddVersion("azalea", "1.17")
                .WithPath("models/block")
                .WithParent("block/template_azalea")
                .AddTexture("top", "block/azalea_top")
                .AddTexture("side", "block/azalea_side");
        }
    }
}
