using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Cube_BottomTop : JavaBlockModel
    {
        public Cube_BottomTop() : base("Cube, Bottom & Top")
        {
            AddVersion("cube_bottom_top", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube")
                .AddTexture("up", "#top")
                .AddTexture("down", "#bottom")
                .AddTexture("north", "#side")
                .AddTexture("south", "#side")
                .AddTexture("west", "#side")
                .AddTexture("east", "#side");
        }
    }
}
