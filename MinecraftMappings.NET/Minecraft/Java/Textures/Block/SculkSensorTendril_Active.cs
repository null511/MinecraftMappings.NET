using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SculkSensorTendril_Active : JavaBlockTexture
    {
        public SculkSensorTendril_Active() : base("Sculk Sensor Tendril, Active")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sculk_sensor_tendril_active");
                //.WithDefaultModel<Java.Models.Block.SculkSensor>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SculkSensorTendril_Active>();
        }
    }
}
