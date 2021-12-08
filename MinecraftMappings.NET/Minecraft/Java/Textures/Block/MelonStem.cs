using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class MelonStem : JavaBlockTexture
    {
        public MelonStem() : base("Melon Stem")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("melon_stem")
                .WithDefaultModel<Java.Models.Block.MelonStem_Stage7>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.MelonStemDisconnected>();
        }
    }
}
