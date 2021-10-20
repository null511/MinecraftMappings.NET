using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cornflower : JavaBlockModel
    {
        public Cornflower() : base("Cornflower")
        {
            AddVersion("cornflower", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/cornflower");
        }
    }
}
