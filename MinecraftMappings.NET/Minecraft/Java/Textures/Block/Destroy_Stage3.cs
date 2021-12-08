using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Destroy_Stage3 : JavaBlockTexture
    {
        public Destroy_Stage3() : base("Destroy, Stage 3")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("destroy_stage_3");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Destroy_Stage3>();
        }
    }
}
