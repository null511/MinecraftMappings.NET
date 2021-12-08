using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaDoorTop : JavaBlockTexture
    {
        public AcaciaDoorTop() : base("Acacia Door, Top")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "acacia_door_top")
                .WithMinVersion("1.8")
                .WithDefaultModel<Java.Models.Block.AcaciaDoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorAcaciaUpper>();
        }
    }
}
