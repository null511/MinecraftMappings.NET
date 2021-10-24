using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class JackOLantern : JavaBlockTexture
    {
        public JackOLantern() : base("Jack O'Lantern")
        {
            AddVersion("jack_o_lantern")
                .WithDefaultModel<Java.Models.Block.JackOLantern>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PumpkinFaceOn>();
        }
    }
}
