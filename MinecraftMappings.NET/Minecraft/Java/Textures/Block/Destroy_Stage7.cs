using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Destroy_Stage7 : JavaBlockTexture
    {
        public Destroy_Stage7() : base("Destroy, Stage 7")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("destroy_stage_7");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Destroy_Stage7>();
        }
    }
}
