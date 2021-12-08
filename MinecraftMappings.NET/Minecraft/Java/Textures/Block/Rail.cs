using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Rail : JavaBlockTexture
    {
        public Rail() : base("Rail")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("rail")
                .WithDefaultModel<Java.Models.Block.Rail>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RailNormal>();
        }
    }
}
