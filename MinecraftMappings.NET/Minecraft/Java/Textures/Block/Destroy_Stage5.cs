using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Destroy_Stage5 : JavaBlockTexture
    {
        public Destroy_Stage5() : base("Destroy, Stage 5")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("destroy_stage_5");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Destroy_Stage5>();
        }
    }
}
