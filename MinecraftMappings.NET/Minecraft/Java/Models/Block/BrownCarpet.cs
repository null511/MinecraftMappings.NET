using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BrownCarpet : JavaBlockModel
    {
        public BrownCarpet() : base("Brown Carpet")
        {
            AddVersion("brown_carpet", "1.6.1")
                .WithPath("models/block")
                .WithParent("block/carpet")
                .AddTexture("wool", "block/brown_wool");
        }
    }
}
