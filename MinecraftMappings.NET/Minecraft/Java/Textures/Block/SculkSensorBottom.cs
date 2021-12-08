using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SculkSensorBottom : JavaBlockTexture
    {
        public SculkSensorBottom() : base("Sculk Sensor Bottom")
        {
            AddVersion("sculk_sensor_bottom");
                //.WithDefaultModel<Java.Models.Block.SculkSensor>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SculkSensorBottom>();
        }
    }
}
