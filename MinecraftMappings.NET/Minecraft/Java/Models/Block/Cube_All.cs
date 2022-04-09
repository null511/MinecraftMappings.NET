using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cube_All : JavaBlockModel
    {
        public Cube_All() : base("Cube, All")
        {
            AddVersion("cube_all", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube")
                .AddTexture("up", "#all")
                .AddTexture("down", "#all")
                .AddTexture("north", "#all")
                .AddTexture("south", "#all")
                .AddTexture("west", "#all")
                .AddTexture("east", "#all");
        }
    }
}
