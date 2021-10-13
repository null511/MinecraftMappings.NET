using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class OrientableVertical : JavaBlockModel
    {
        public OrientableVertical() : base("Orientable, Vertical")
        {
            AddVersion("orientable_vertical", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube")
                .AddTexture("up", "#front")
                .AddTexture("down", "#side")
                .AddTexture("north", "#side")
                .AddTexture("south", "#side")
                .AddTexture("west", "#side")
                .AddTexture("east", "#side");
        }
    }
}
