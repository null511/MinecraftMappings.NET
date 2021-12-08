using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LavaFlow : JavaBlockTexture
    {
        public LavaFlow() : base("Lava Flow")
        {
            AddVersion("lava_flow");
                //.WithDefaultModel<Java.Models.Block.LavaFlow>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LavaFlow>();
        }
    }
}
