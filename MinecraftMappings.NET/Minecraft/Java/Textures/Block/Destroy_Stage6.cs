using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Destroy_Stage6 : JavaBlockTexture
    {
        public Destroy_Stage6() : base("Destroy, Stage 6")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("destroy_stage_6");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Destroy_Stage6>();
        }
    }
}
