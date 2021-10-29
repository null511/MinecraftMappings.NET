using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Dirt : JavaBlockModel
    {
        public Dirt() : base("Dirt")
        {
            AddVersion("dirt", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/dirt");
        }
    }
}
