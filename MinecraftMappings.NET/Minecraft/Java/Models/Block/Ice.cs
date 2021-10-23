using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Ice : JavaBlockModel
    {
        public Ice() : base("Ice")
        {
            AddVersion("ice", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/ice");
        }
    }
}
