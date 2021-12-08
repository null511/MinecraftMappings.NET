using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TurtleEgg_VeryCracked : JavaBlockTexture
    {
        public TurtleEgg_VeryCracked() : base("Turtle Egg, Very Cracked")
        {
            AddVersion("turtle_egg_very_cracked");
                //.WithDefaultModel<Java.Models.Block.TurtleEgg_VeryCracked>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TurtleEgg_VeryCracked>();
        }
    }
}
