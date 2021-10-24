using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LilyOfTheValley : JavaBlockTexture
    {
        public LilyOfTheValley() : base("Lily Of The Valley")
        {
            AddVersion("lily_of_the_valley")
                .WithDefaultModel<Java.Models.Block.LilyOfTheValley>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerLilyOfTheValley>();
        }
    }
}
