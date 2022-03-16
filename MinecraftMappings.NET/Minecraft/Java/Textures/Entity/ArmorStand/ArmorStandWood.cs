using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.ArmorStand
{
    public class ArmorStandWood : JavaEntityTexture
    {
        public ArmorStandWood() : base("Armor Stand Wood")
        {
            AddVersion("wood")
                .WithPath("entity/armorstand")
                .WithDefaultModel<Java.Models.Entity.ArmorStand>();
                //.MapsToBedrockEntity<BedrockEntities.ArmorStandWood>();
        }
    }
}
