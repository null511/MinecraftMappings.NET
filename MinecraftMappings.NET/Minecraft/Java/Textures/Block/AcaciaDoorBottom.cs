using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaDoorBottom : JavaBlockTexture
    {
        public AcaciaDoorBottom() : base("Acacia Door, Bottom")
        {
            AddVersion("acacia_door_bottom")
                .WithDefaultModel<Java.Models.Block.AcaciaDoorBottom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorAcaciaLower>();
        }
    }
}
