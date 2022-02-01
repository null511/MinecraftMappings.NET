using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.ArmorStand
{
    public class Wood : JavaEntityTexture
    {
        public Wood() : base("Armor Stand Wood")
        {
            AddVersion("wood")
                .WithPath("entity/armorstand")
                .WithDefaultModel<Java.Models.Entity.ArmorStand>();
                //.MapsToBedrockEntity<BedrockEntities.Witch>();
        }
    }
}
