using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Ladder : JavaBlockTexture
    {
        public Ladder() : base("Ladder")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("ladder")
                .WithDefaultModel<Java.Models.Block.Ladder>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Ladder>();
        }
    }
}
