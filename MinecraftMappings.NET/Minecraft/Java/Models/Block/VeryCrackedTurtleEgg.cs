using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class VeryCrackedTurtleEgg : JavaBlockModel
    {
        public VeryCrackedTurtleEgg() : base("Very Cracked Turtle Egg")
        {
            AddVersion("very_cracked_turtle_egg", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/template_turtle_egg")
                .AddTexture("all", "block/turtle_egg_very_cracked");
        }
    }
}
