using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Tuff : JavaBlockModel
    {
        public Tuff() : base("Tuff")
        {
            AddVersion("tuff", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/tuff");
        }
    }
}
