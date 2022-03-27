using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Models
{
    public class TurtleArmor_Layer1 : JavaEntityTexture
    {
        public TurtleArmor_Layer1() : base("Turtle Armor, Layer 1")
        {
            AddVersion("turtle_layer_1")
                .WithPath("models/armor")
                .WithDefaultModel<Java.Models.Entity.ArmorLayer1>();
                //.MapsToBedrockEntity<BedrockEntities.TurtleArmor_Layer1>();
        }
    }
}
