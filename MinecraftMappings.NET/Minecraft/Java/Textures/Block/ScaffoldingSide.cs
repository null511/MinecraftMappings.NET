using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ScaffoldingSide : JavaBlockTexture
    {
        public ScaffoldingSide() : base("Scaffolding Side")
        {
            AddVersion("scaffolding_side");
                //.WithDefaultModel<Java.Models.Block.Scaffolding>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.ScaffoldingSide>();
        }
    }
}
