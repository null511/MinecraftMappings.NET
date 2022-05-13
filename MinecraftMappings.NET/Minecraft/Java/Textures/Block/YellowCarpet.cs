using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class YellowCarpet : JavaBlockTexture
    {
        public YellowCarpet() : base("Yellow Carpet")
        {
            AddVersion("yellow_carpet")
                .WithDefaultModel<Java.Models.Block.YellowCarpet>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.YellowCarpet>();
        }
    }
}
