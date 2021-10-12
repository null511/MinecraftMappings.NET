using MinecraftMappings.Internal.Models;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CubeAll : JavaModelData
    {
        public CubeAll() : base("Cube, All")
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
