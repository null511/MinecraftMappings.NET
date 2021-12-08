using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Stone : JavaBlockTexture
    {
        public Stone() : base("Stone")
        {
            AddVersion("stone")
                .WithDefaultModel<Java.Models.Block.Stone>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Stone>();
        }
    }
}
