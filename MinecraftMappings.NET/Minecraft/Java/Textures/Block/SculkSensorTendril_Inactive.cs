using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SculkSensorTendril_Inactive : JavaBlockTexture
    {
        public SculkSensorTendril_Inactive() : base("Sculk Sensor Tendril, Inactive")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("sculk_sensor_tendril_inactive");
                //.WithDefaultModel<Java.Models.Block.SculkSensor>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SculkSensorTendril_Inactive>();
        }
    }
}
