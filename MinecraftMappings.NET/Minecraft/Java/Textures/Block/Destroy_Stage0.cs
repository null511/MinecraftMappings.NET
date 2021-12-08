using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Destroy_Stage0 : JavaBlockTexture
    {
        public Destroy_Stage0() : base("Destroy, Stage 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("destroy_stage_0");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Destroy_Stage0>();
        }
    }
}
