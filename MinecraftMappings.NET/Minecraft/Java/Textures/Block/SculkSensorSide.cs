using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SculkSensorSide : JavaBlockTexture
    {
        public SculkSensorSide() : base("Sculk Sensor Side")
        {
            AddVersion("sculk_sensor_side");
                //.WithDefaultModel<Java.Models.Block.SculkSensor>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SculkSensorSide>();
        }
    }
}
