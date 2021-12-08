using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Destroy_Stage2 : JavaBlockTexture
    {
        public Destroy_Stage2() : base("Destroy, Stage 2")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("destroy_stage_2");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Destroy_Stage2>();
        }
    }
}
