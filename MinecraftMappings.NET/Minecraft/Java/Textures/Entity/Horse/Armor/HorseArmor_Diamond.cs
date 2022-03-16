using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse.Armor
{
    public class HorseArmor_Diamond : JavaEntityTexture
    {
        public HorseArmor_Diamond() : base("Horse Armor, Diamond")
        {
            AddVersion("horse_armor_diamond")
                .WithPath("entity/horse/armor")
                .WithDefaultModel<Java.Models.Entity.HorseArmor>();
                //.MapsToBedrockEntity<BedrockEntities.HorseArmor_Diamond>();
        }
    }
}
