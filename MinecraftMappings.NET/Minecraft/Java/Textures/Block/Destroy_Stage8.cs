using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Destroy_Stage8 : JavaBlockTexture
    {
        public Destroy_Stage8() : base("Destroy, Stage 8")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("destroy_stage_8");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Destroy_Stage8>();
        }
    }
}
