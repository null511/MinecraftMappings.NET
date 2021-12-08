using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class RailCorner : JavaBlockTexture
    {
        public RailCorner() : base("Rail Corner")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("rail_corner")
                .WithDefaultModel<Java.Models.Block.RailCorner>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RailNormalTurned>();
        }
    }
}
