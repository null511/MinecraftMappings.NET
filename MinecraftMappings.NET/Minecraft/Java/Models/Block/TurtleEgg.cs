using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class TurtleEgg : JavaBlockModel
    {
        public TurtleEgg() : base("Turtle Egg")
        {
            AddVersion("turtle_egg", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_turtle_egg")
                .AddTexture("all", "block/turtle_egg");
        }
    }
}
