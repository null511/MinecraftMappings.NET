using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Bamboo_Stage0 : JavaBlockTexture
    {
        public Bamboo_Stage0() : base("Bamboo, Stage 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(4, "bamboo_stage0")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.BambooSapling>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BambooStem>();
        }
    }
}
