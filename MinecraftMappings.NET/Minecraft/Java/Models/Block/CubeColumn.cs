using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CubeColumn : JavaBlockModel
    {
        public CubeColumn() : base("Cube, Column")
        {
            AddVersion("cube_column", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube")
                .AddTexture("up", "#end")
                .AddTexture("down", "#end")
                .AddTexture("north", "#side")
                .AddTexture("south", "#side")
                .AddTexture("west", "#side")
                .AddTexture("east", "#side");
        }
    }
}
