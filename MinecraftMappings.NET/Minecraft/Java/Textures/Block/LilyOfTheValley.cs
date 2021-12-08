using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LilyOfTheValley : JavaBlockTexture
    {
        public LilyOfTheValley() : base("Lily Of The Valley")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(4, "lily_of_the_valley")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.LilyOfTheValley>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerLilyOfTheValley>();
        }
    }
}
