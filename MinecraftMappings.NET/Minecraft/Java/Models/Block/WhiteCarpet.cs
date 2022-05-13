using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class WhiteCarpet : JavaBlockModel
    {
        public WhiteCarpet() : base("White Carpet")
        {
            AddVersion("white_carpet", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/carpet")
                .AddTexture("wool", "block/white_wool");
        }
    }
}
