using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlackCarpet : JavaBlockModel
    {
        public BlackCarpet() : base("Black Carpet")
        {
            AddVersion("black_carpet", "1.6.1")
                .WithPath("models/block")
                .WithParent("block/carpet")
                .AddTexture("wool", "block/black_wool");
        }
    }
}
