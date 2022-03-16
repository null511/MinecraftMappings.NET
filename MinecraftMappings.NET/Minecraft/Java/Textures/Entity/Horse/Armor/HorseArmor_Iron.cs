using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse.Armor
{
    public class HorseArmor_Iron : JavaEntityTexture
    {
        public HorseArmor_Iron() : base("Horse Armor, Iron")
        {
            AddVersion("horse_armor_iron")
                .WithPath("entity/horse/armor")
                .WithDefaultModel<Java.Models.Entity.HorseArmor>();
                //.MapsToBedrockEntity<BedrockEntities.HorseArmor_Iron>();
        }
    }
}
