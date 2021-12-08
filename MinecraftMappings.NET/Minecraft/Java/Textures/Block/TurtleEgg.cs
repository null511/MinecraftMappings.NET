using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TurtleEgg : JavaBlockTexture
    {
        public TurtleEgg() : base("Turtle Egg")
        {
            AddVersion("turtle_egg");
                //.WithDefaultModel<Java.Models.Block.TurtleEgg>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TurtleEgg>();
        }
    }
}
