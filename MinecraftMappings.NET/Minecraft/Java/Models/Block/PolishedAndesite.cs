using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class PolishedAndesite : JavaBlockModel
    {
        public PolishedAndesite() : base("Polished Andesite")
        {
            AddVersion("polished_andesite", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/polished_andesite");
        }
    }
}
