using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Destroy_Stage9 : JavaBlockTexture
    {
        public Destroy_Stage9() : base("Destroy, Stage 9")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("destroy_stage_9");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Destroy_Stage9>();
        }
    }
}
