using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerLilyOfTheValley : BedrockBlockTexture
    {
        public FlowerLilyOfTheValley() : base("Flower, Lily Of The Valley")
        {
            AddVersion("flower_lily_of_the_valley")
                .MapsToJavaBlock<Java.Textures.Block.LilyOfTheValley>();
        }
    }
}
