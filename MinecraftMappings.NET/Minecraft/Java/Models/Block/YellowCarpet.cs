using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class YellowCarpet : JavaBlockModel
    {
        public YellowCarpet() : base("Yellow Carpet")
        {
            AddVersion("yellow_carpet", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/carpet")
                .AddTexture("wool", "block/yellow_wool");
        }
    }
}
