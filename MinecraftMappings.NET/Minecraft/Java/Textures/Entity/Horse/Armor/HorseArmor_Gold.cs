using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Horse.Armor
{
    public class HorseArmor_Gold : JavaEntityTexture
    {
        public HorseArmor_Gold() : base("Horse Armor, Gold")
        {
            AddVersion("horse_armor_gold")
                .WithPath("entity/horse/armor")
                .WithDefaultModel<Java.Models.Entity.HorseArmor>();
                //.MapsToBedrockEntity<BedrockEntities.HorseArmor_Gold>();
        }
    }
}
