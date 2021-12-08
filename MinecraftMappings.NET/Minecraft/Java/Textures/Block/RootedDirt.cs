using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RootedDirt : JavaBlockTexture
    {
        public RootedDirt() : base("Rooted Dirt")
        {
            AddVersion("rooted_dirt");
                //.WithDefaultModel<Java.Models.Block.RootedDirt>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RootedDirt>();
        }
    }
}
