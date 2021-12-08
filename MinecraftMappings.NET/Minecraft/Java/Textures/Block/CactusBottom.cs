using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CactusBottom : JavaBlockTexture
    {
        public CactusBottom() : base("Cactus Bottom")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("cactus_bottom")
                .WithDefaultModel<Java.Models.Block.Cactus>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CactusBottom>();
        }
    }
}
