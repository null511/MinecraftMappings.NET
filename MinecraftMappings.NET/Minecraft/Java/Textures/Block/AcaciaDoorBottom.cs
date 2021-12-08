using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaDoorBottom : JavaBlockTexture
    {
        public AcaciaDoorBottom() : base("Acacia Door, Bottom")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "acacia_door_bottom")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.AcaciaDoorBottom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorAcaciaLower>();
        }
    }
}
