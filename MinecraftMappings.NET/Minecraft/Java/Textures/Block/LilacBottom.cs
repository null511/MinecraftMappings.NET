using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LilacBottom : JavaBlockTexture
    {
        public LilacBottom() : base("Lilac Bottom")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("lilac_bottom");
                //.WithDefaultModel<Java.Models.Block.LilacBottom>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LilacBottom>();
        }
    }
}
