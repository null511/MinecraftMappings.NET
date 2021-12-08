using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TurtleEgg_SlightlyCracked : JavaBlockTexture
    {
        public TurtleEgg_SlightlyCracked() : base("Turtle Egg, Slightly Cracked")
        {
            AddVersion("turtle_egg_slightly_cracked");
                //.WithDefaultModel<Java.Models.Block.TurtleEgg_SlightlyCracked>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TurtleEgg_SlightlyCracked>();
        }
    }
}
