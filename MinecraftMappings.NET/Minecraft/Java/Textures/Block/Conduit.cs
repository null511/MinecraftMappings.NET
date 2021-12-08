using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Conduit : JavaBlockTexture
    {
        public Conduit() : base("Conduit")
        {
            AddVersion("conduit");
                //.WithDefaultModel<Java.Models.Block.Conduit>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CopperOre>();
        }
    }
}
