using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class PumpkinFaceOn : BedrockBlockTexture
    {
        public PumpkinFaceOn() : base("Pumpkin Face, On")
        {
            AddVersion("pumpkin_face_on")
                .MapsToJavaBlock<Java.Textures.Block.JackOLantern>();
        }
    }
}
