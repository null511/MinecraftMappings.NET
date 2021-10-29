using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueCarpet : JavaBlockModel
    {
        public BlueCarpet() : base("Blue Carpet")
        {
            AddVersion("blue_carpet", "1.6.1")
                .WithPath("models/block")
                .WithParent("block/carpet")
                .AddTexture("wool", "block/blue_wool");
        }
    }
}
