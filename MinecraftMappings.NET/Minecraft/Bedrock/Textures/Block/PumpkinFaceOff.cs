using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class PumpkinFaceOff : BedrockBlockTexture
    {
        public PumpkinFaceOff() : base("Pumpkin Face, Off")
        {
            AddVersion("pumpkin_face_off")
                .MapsToJavaBlock<Java.Textures.Block.CarvedPumpkin>();
        }
    }
}
