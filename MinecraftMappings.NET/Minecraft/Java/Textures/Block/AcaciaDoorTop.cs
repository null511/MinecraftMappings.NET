using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AcaciaDoorTop : JavaBlockTexture
    {
        public AcaciaDoorTop() : base("Acacia Door, Top")
        {
            AddVersion("acacia_door_top")
                .WithDefaultModel<Java.Models.Block.AcaciaDoorTop>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorAcaciaUpper>();
        }
    }
}
