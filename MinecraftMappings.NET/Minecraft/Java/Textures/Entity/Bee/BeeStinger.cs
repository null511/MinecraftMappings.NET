using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Bee
{
    public class BeeStinger : JavaEntityTexture
    {
        public BeeStinger() : base("Bee Stinger")
        {
            AddVersion("bee_stinger");
                //.WithDefaultModel<Java.Models.Entity.BeeStinger>()
                //.MapsToBedrockEntity<BedrockEntities.BeeStinger>();
        }
    }
}
