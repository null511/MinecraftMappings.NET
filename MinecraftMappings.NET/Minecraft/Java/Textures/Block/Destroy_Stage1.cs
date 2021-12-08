using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Destroy_Stage1 : JavaBlockTexture
    {
        public Destroy_Stage1() : base("Destroy, Stage 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("destroy_stage_1");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Destroy_Stage1>();
        }
    }
}
