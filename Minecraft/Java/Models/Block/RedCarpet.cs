using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RedCarpet : JavaModelData
    {
        public RedCarpet() : base("Red Carpet")
        {
            AddVersion("red_carpet", "1.6.1")
                .WithPath("models/block")
                .WithParent("block/carpet")
                .AddTexture("wool", "block/red_wool");
        }
    }
}
