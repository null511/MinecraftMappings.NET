using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PumpkinStem : JavaBlockTexture
    {
        public PumpkinStem() : base("Pumpkin Stem")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("pumpkin_stem")
                .WithDefaultModel<Java.Models.Block.PumpkinStem_Stage7>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PumpkinStemDisconnected>();
        }
    }
}
