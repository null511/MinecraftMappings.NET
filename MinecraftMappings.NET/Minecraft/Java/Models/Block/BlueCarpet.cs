using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BlueCarpet : JavaModelData
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
