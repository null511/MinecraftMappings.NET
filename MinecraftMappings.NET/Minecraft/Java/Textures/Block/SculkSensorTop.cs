using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SculkSensorTop : JavaBlockTexture
    {
        public SculkSensorTop() : base("Sculk Sensor Top")
        {
            AddVersion("sculk_sensor_top");
                //.WithDefaultModel<Java.Models.Block.SculkSensor>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SculkSensorTop>();
        }
    }
}
