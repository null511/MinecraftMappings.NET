using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class IronDoorTop : JavaBlockTexture
    {
        public IronDoorTop() : base("Iron Door Top")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("iron_door_top");
                //.WithDefaultModel<Java.Models.Block.IronDoorTop>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoorIronUpper>();
        }
    }
}
