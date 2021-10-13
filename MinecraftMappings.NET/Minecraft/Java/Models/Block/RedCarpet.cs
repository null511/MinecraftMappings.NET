using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class RedCarpet : JavaBlockModel
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
