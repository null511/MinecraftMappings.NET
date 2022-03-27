using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Clay : JavaBlockTexture
    {
        public Clay() : base("Clay")
        {
            AddVersion("clay")
                .WithDefaultModel<Java.Models.Block.Clay>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Clay>();
        }
    }
}
