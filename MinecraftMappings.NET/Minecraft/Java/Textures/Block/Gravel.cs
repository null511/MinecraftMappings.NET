using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Gravel : JavaBlockTexture
    {
        public Gravel() : base("Gravel")
        {
            AddVersion("gravel");
                //.WithDefaultModel<Java.Models.Block.Gravel>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Gravel>();
        }
    }
}
