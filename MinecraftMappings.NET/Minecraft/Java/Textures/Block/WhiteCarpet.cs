using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WhiteCarpet : JavaBlockTexture
    {
        public WhiteCarpet() : base("White Carpet")
        {
            AddVersion("white_carpet")
                .WithDefaultModel<Java.Models.Block.WhiteCarpet>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WhiteCarpet>();
        }
    }
}
