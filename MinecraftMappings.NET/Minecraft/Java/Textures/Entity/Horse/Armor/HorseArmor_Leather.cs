using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse.Armor
{
    public class HorseArmor_Leather : JavaEntityTexture
    {
        public HorseArmor_Leather() : base("Horse Armor, Leather")
        {
            AddVersion("horse_armor_leather")
                .WithPath("entity/horse/armor")
                .WithDefaultModel<Java.Models.Entity.HorseArmor>();
                //.MapsToBedrockEntity<BedrockEntities.HorseArmor_Leather>();
        }
    }
}
